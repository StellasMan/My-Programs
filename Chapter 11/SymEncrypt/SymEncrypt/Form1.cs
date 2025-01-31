using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SymEncrypt
{
	public partial class SymEncryptForm : Form
	{
		public SymEncryptForm()
		{
			InitializeComponent();
		}

		private void OnBtnEncryptInput(object sender, EventArgs e)
		{
			String sFilePath;
			if (FindFile("Select File to Encrypt", "txt", "txt files (*.txt)|*.txt|All files (*.*)|*.*", true, out sFilePath))
			{
				txtEncryptIn.Text = sFilePath;
			}
		}

		private void OnBtnEncryptOutput(object sender, EventArgs e)
		{
			String sFilePath;
			if (FindFile("Name of Encrypted File", "enc", "Encrypted files (*.enc)|*.enc|All files (*.*)|*.*", false, out sFilePath))
			{
				txtEncryptOut.Text = sFilePath;
			}
		}

		private void OnBtnDecryptInput(object sender, EventArgs e)
		{
			String sFilePath;
			if (FindFile("Select File to Decrypt", "enc", "Encrypted files (*.enc)|*.enc|All files (*.*)|*.*", false, out sFilePath))
			{
				txtDecryptIn.Text = sFilePath;
			}
		}

		private void OnBtnDecryptOutput(object sender, EventArgs e)
		{
			String sFilePath;
			if (FindFile("Name of Decrypted File", "txt", "txt files (*.txt)|*.txt|All files (*.*)|*.*", true, out sFilePath))
			{
				txtDecryptOut.Text = sFilePath;
			}
		}

		private void OnBtnEncrypt(object sender, EventArgs e)
		{
			String sSrcFile = txtEncryptIn.Text;
			String sDestFile = txtEncryptOut.Text;

			m_sPassword = txtPassword.Text;

			if (m_sPassword.Length >= 8)
			{
				// Open the plain text file
				if (File.Exists(sSrcFile))
				{
					bool bAllOK = true;
					if (File.Exists(sDestFile))
					{
						bAllOK = false;
						String sMsg = String.Format("Target file {0} already exists.\nDo you wish to overwrite it?", sDestFile);
						if (MessageBox.Show(sMsg, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							File.Delete(sDestFile);
							bAllOK = true;
						}
					}

					if (bAllOK)
					{
						SymmetricAlgorithm cryptoAlgorithm = SymmetricAlgorithm.Create(ENC_ALGORITHM);
						UInt32 uiBlkSizeInBytes = (UInt32)cryptoAlgorithm.BlockSize/8;
						cryptoAlgorithm.IV = GenerateIV(uiBlkSizeInBytes);
						cryptoAlgorithm.Key = GenerateKeyFromPassword(m_sPassword, cryptoAlgorithm);
						ICryptoTransform icryptTransform = cryptoAlgorithm.CreateEncryptor();

						using (FileStream fileDestStream = File.Open(sDestFile, FileMode.Create))
						{
							using (CryptoStream csEncrypt = new CryptoStream(fileDestStream, icryptTransform, CryptoStreamMode.Write))
							{
								using (FileStream fileSrcStream = File.Open(sSrcFile, FileMode.Open, FileAccess.Read, FileShare.Read))
								{
									int nBytesRead = 0;
									byte[] byBuffer = new byte[uiBlkSizeInBytes];
									while ((nBytesRead = fileSrcStream.Read(byBuffer, 0, (int)uiBlkSizeInBytes)) > 0)
									{
										csEncrypt.Write(byBuffer, 0, nBytesRead);
									}

									fileSrcStream.Close();
								}

								csEncrypt.Close();
							}
						}

						cryptoAlgorithm.Clear();
					}

					//if (bAllOK)
					//{
					//	FileInfo filInfo = new FileInfo(sSrcFile);
					//	long lLength = filInfo.Length;
					//	using (FileStream fs = File.OpenRead(sSrcFile))
					//	{
					//		byte[] abyPlainText = new byte[lLength];
					//		if (fs.Read(abyPlainText, 0, abyPlainText.Length) > 0)
					//		{
					//			byte[] abyEncryptedText;
					//			if (EncryptData(m_sPassword, abyPlainText, out abyEncryptedText))
					//			{
					//				using (BinaryWriter writer = new BinaryWriter(File.Open(sDestFile, FileMode.Create)))
					//				{
					//					writer.Write(abyEncryptedText);
					//				}
					//			}
					//		}
					//		else
					//		{
					//			String sMsg = String.Format("Error reading input file {0}", sSrcFile);
					//			MessageBox.Show(sMsg, "Warning", MessageBoxButtons.OK);
					//		}

					//		fs.Close();
					//	}
					//}
				}
			}
			else
			{
				MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK);
			}
		}

		private void OnDecrypt(object sender, EventArgs e)
		{
			String sSrcFile = txtDecryptIn.Text;
			String sDestFile = txtDecryptOut.Text;

			m_sPassword = txtPassword.Text;

			if (m_sPassword.Length >= 8)
			{
				// Open the plain text file
				if (File.Exists(sSrcFile))
				{
					bool bAllOK = true;
					if (File.Exists(sDestFile))
					{
						bAllOK = false;
						String sMsg = String.Format("Target file {0} already exists.\nDo you wish to overwrite it?", sDestFile);
						if (MessageBox.Show(sMsg, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							File.Delete(sDestFile);
							bAllOK = true;
						}
					}

					if (bAllOK)
					{
						FileInfo filInfo = new FileInfo(sSrcFile);
						int nLength = (int)filInfo.Length;
						using (BinaryReader reader = new BinaryReader(File.Open(sSrcFile, FileMode.Open)))
						{
							byte[] byBuff = new byte[nLength];
							if (reader.Read(byBuff, 0, nLength) == nLength)
							{
								byte[] abyPlainText;
								if (DecryptData(m_sPassword, byBuff, out abyPlainText))
								{
									// Output decrypted text file
									using (FileStream fs = File.OpenWrite(sDestFile))
									{
										fs.Write(abyPlainText, 0, abyPlainText.Length);

										fs.Close();
									}
								}
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Password must be at least 8 characters long", "Error", MessageBoxButtons.OK);
			}
		}

		bool FindFile(String sTitle, String sDfltExt, String sFilter, bool bFileExists, out String sFilePath)
		{
			bool bRetVal = false;
			sFilePath = String.Empty;

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = ".";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Title = sTitle;
			openFileDialog.DefaultExt = sDfltExt;
			openFileDialog.Filter = sFilter;
			openFileDialog.CheckFileExists = bFileExists;
			openFileDialog.CheckPathExists = true;
			openFileDialog.Multiselect = false;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				sFilePath = openFileDialog.FileName;
				bRetVal = true;
			}

			return bRetVal;
		}

		private bool EncryptData(String sPassword, byte[] abyPlainText, out byte[] abyEncryptedText)
		{
			bool bRetVal = true;

			SymmetricAlgorithm cryptoAlgorithm = SymmetricAlgorithm.Create(ENC_ALGORITHM);
			UInt32 uiBlkSize = (UInt32)cryptoAlgorithm.BlockSize;
			cryptoAlgorithm.IV = GenerateIV(uiBlkSize / 8);
			cryptoAlgorithm.Key = GenerateKeyFromPassword(sPassword, cryptoAlgorithm);
			ICryptoTransform icryptTransform = cryptoAlgorithm.CreateEncryptor();

			try
			{
				byte[] byCipherData = icryptTransform.TransformFinalBlock(abyPlainText, 0, abyPlainText.Length);
				abyEncryptedText = byCipherData;
			}
			catch (CryptographicException ex)
			{
				MessageBox.Show(String.Format("Exception attempting to encrypt data.\n{0}", ex.Message), "Error", MessageBoxButtons.OK);
				abyEncryptedText = null;
				bRetVal = false;
			}

			cryptoAlgorithm.Clear();

			return bRetVal;
		}

		private bool DecryptData(String sPassword, byte[] abyEncryptedText, out byte[] abyPlainText)
		{
			bool bRetVal = true;

			SymmetricAlgorithm cryptoAlgorithm = SymmetricAlgorithm.Create(ENC_ALGORITHM);
			UInt32 uiBlkSizeInBytes = (UInt32)cryptoAlgorithm.BlockSize/8;
			cryptoAlgorithm.IV = GenerateIV(uiBlkSizeInBytes);
			cryptoAlgorithm.Key = GenerateKeyFromPassword(sPassword, cryptoAlgorithm);
			ICryptoTransform icryptTransform = cryptoAlgorithm.CreateDecryptor();

			try
			{
				byte[] byCipherData = icryptTransform.TransformFinalBlock(abyEncryptedText, 0, abyEncryptedText.Length);
				abyPlainText = byCipherData;
			}
			catch(CryptographicException ex)
			{
				MessageBox.Show(String.Format("Exception attempting to decrypt data.\n{0}", ex.Message), "Error", MessageBoxButtons.OK);
				abyPlainText = null;
				bRetVal = false;
			}

			cryptoAlgorithm.Clear();

			return bRetVal;
		}

		byte[] GenerateKeyFromPassword(String sPassword, SymmetricAlgorithm cryptoAlgorithm)
		{
			int nLenInBits = sPassword.Length * CHAR_SIZE;
			int nMinKeySize = -1;
			byte[] abyKey = null;

			KeySizes[] keySizes = cryptoAlgorithm.LegalKeySizes;

			foreach(KeySizes keySize in keySizes)
			{
				Debug.WriteLine(String.Format("Minimum: {0}; Maximum: {1}; sizeof(char) {2} sizeof(byte) {3}", keySize.MinSize, keySize.MaxSize, sizeof(char), sizeof(byte)));
				if (keySize.MaxSize >= nLenInBits)
					nMinKeySize = keySize.MaxSize;
			}

			if (nMinKeySize > 0)
			{
				abyKey = new byte[nMinKeySize/8];
				char[] aChars = sPassword.ToCharArray();

				int nCount = 0;
				foreach(char ch in aChars)
				{
					abyKey[nCount++] = (byte)ch;
				}

				Random rnd = new Random(RND_SEED);
				for (int nIx=nCount; nIx<nMinKeySize/8; nIx++)
				{
					abyKey[nIx] = (byte)rnd.Next(0, 255);
				}
			}

			return abyKey;
		}

		byte[] GenerateIV(UInt32 uiBlkSize)
		{
			byte[] abyBlock = new byte[uiBlkSize];

			Random rnd = new Random(RND_SEED);
			for (UInt32 uiIx = 0; uiIx<uiBlkSize; uiIx++)
			{
				abyBlock[uiIx] = (byte)rnd.Next(0, 255);
			}

			return abyBlock;
		}

		private void OnBtnOK(object sender, EventArgs e)
		{
			Close();
		}

		private String m_sPassword;
		private const Int32 BLK_SIZE = 1024;
		private const Int32 RND_SEED = 122670;
		private const UInt16 CHAR_SIZE = sizeof(char) * 8;  // Size of a character, in bits
		private const String ENC_ALGORITHM = "AesManaged";
	}
}
