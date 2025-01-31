using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsymEncrypt
{
	public partial class AsymEncryptForm : Form
	{
		public AsymEncryptForm()
		{
			InitializeComponent();
			AssignNewKey();

			radioEncrypt.Checked = true;
		}

		private void OnEncrypt(object sender, EventArgs e)
		{
			String sSrcFile = txtSource.Text;
			String sDestFile = txtDest.Text;

			if (radioEncrypt.Checked)
				EncryptFile1(sSrcFile, sDestFile);
			else
				DecryptFile1(sSrcFile, sDestFile);
		}

		private bool EncryptFile1(String sSrcFile, String sDestFile)
		{
			Int64 nRemaining = -1;

			try
			{
				using (FileStream fsInput = new FileStream(sSrcFile, FileMode.Open))
				{
					FileInfo filInfo = new FileInfo(sSrcFile);
					nRemaining = filInfo.Length;
					int nBufferSize = PublicKey.Length / 2;
					using (FileStream fsOutput = new FileStream(sDestFile, FileMode.Create))
					{
						using (BinaryWriter bWriter = new BinaryWriter(fsOutput))
						{
							byte[] abyInput = new byte[nBufferSize];

							while (true)
							{
								int nBytesToRead = (int)Math.Min(nRemaining, nBufferSize);
								if (nBytesToRead < nBufferSize)
									abyInput = new byte[nBytesToRead];

								int nRead = fsInput.Read(abyInput, 0, nBytesToRead);
								if (nRead > 0)
								{
									byte[] abyEncrypted = rsa.Encrypt(abyInput, true);
									bWriter.Write(abyEncrypted);

									byte[] abyDecrypted = rsa.Decrypt(abyEncrypted, true);

									nRemaining -= nRead;
								}

								if ((nRead == 0) || (nRemaining == 0))
								{
									break;
								}
							}

							bWriter.Flush();
							bWriter.Close();
						}
					}

					fsInput.Close();
				}
			}

			catch (CryptographicException ex)
			{
				MessageBox.Show(String.Format("CryptographicException attempting to encrypt source file {0}\n{1}", sSrcFile, ex.Message), "Error", MessageBoxButtons.OK);
			}

			catch (Exception ex)
			{
				MessageBox.Show(String.Format("General Exception attempting to encrypt source file {0}\n{1}", sSrcFile, ex.Message), "Error", MessageBoxButtons.OK);
			}

			return true;
		}

		private bool DecryptFile1(String sSrcFile, String sDestFile)
		{
			Int64 nRemaining = -1;

			try
			{
				using (FileStream fsInput = new FileStream(sSrcFile, FileMode.Open))
				{
					FileInfo filInfo = new FileInfo(sSrcFile);
					nRemaining = filInfo.Length;
					int nBufferSize = PublicKey.Length / 2;

					using (BinaryReader binReader = new BinaryReader(fsInput))
					{
						using (FileStream fsOutput = new FileStream(sDestFile, FileMode.Create))
						{
							byte[] abyInput = new byte[nBufferSize];

							while (true)
							{
								int nBytesToRead = (int)Math.Min(nRemaining, nBufferSize);
								if (nBytesToRead < nBufferSize)
									abyInput = new byte[nBytesToRead];

								int nRead = binReader.Read(abyInput, 0, nBytesToRead);
								if (nRead > 0)
								{
									byte[] abyDecrypted = rsa.Decrypt(abyInput, false);
									fsOutput.Write(abyDecrypted, 0, nRead);
									nRemaining -= nRead;
								}

								if ((nRead == 0) || (nRemaining == 0))
								{
									break;
								}
							}

							fsOutput.Flush();
							fsOutput.Close();
						}

						binReader.Close();
					}
				}
			}

			catch (CryptographicException ex)
			{
				MessageBox.Show(String.Format("CryptographicException attempting to decrypt source file {0}\n{1}", sSrcFile, ex.Message), "Error", MessageBoxButtons.OK);
			}

			catch (Exception ex)
			{
				MessageBox.Show(String.Format("General Exception attempting to decrypt source file {0}\n{1}", sSrcFile, ex.Message), "Error", MessageBoxButtons.OK);
			}

			return true;
		}

		private bool EncryptFile(String sSrcFile, String sDestFile)
		{
			CspParameters cspParams = new CspParameters();
			cspParams.KeyContainerName = CONTAINER_NAME;
			Int64 nRemaining = -1;

			RSAParameters publicKey;
			RSAParameters privateKey;

			using (var res = new RSACryptoServiceProvider(cspParams))
			{
				res.PersistKeyInCsp = true;
				publicKey = res.ExportParameters(false);
				privateKey = res.ExportParameters(true);

				res.Clear();
			}

			using (FileStream fsInput = new FileStream(sSrcFile, FileMode.Open))
			{
				FileInfo filInfo = new FileInfo(sSrcFile);
				nRemaining = filInfo.Length;

				using (FileStream fsOutput = new FileStream(sDestFile, FileMode.Create))
				{
					using (BinaryWriter bWriter = new BinaryWriter(fsOutput))
					{
						byte[] abyInput = new byte[BUFFER_SIZE];

						while (true)
						{
							int nBytesToRead = (int)Math.Min(nRemaining, BUFFER_SIZE);
							if (nBytesToRead < BUFFER_SIZE)
								abyInput = new byte[nBytesToRead];

							int nRead = fsInput.Read(abyInput, 0, nBytesToRead);
							if (nRead > 0)
							{
								byte[] abyEncrypted = EncryptUsingRSAParam(abyInput, publicKey);
								bWriter.Write(abyEncrypted);
								nRemaining -= nRead;
							}

							if ((nRead == 0) || (nRemaining == 0))
							{
								break;
							}
						}

						bWriter.Flush();
						bWriter.Close();
					}
				}

				fsInput.Close();
			}

			return (0 == nRemaining);
		}

		private bool DecryptFile(String sSrcFile, String sDestFile)
		{
			Int64 nRemaining = -1;
			CspParameters cspParams = new CspParameters();
			cspParams.KeyContainerName = CONTAINER_NAME;

			RSAParameters publicKey;
			RSAParameters privateKey;

			using (var res = new RSACryptoServiceProvider(cspParams))
			{
				res.PersistKeyInCsp = true;
				publicKey = res.ExportParameters(false);
				privateKey = res.ExportParameters(true);

				res.Clear();
			}

			using (FileStream fsInput = new FileStream(sSrcFile, FileMode.Open))
			{
				FileInfo filInfo = new FileInfo(sSrcFile);
				nRemaining = filInfo.Length;
				using (BinaryReader binReader = new BinaryReader(fsInput))
				{
					using (FileStream fsOutput = new FileStream(sDestFile, FileMode.Create))
					{
						byte[] abyInput = new byte[BUFFER_SIZE];

						while (true)
						{
							int nBytesToRead = (int)Math.Min(nRemaining, BUFFER_SIZE);
							if (nBytesToRead < BUFFER_SIZE)
								abyInput = new byte[nBytesToRead];

							int nRead = binReader.Read(abyInput, 0, nBytesToRead);
							if (nRead > 0)
							{
								byte[] abyDecrypted = DecryptUsingRSAParam(abyInput, privateKey);
								fsOutput.Write(abyDecrypted, 0, nRead);
								nRemaining -= nRead;
							}

							if ((nRead == 0) || (nRemaining == 0))
							{
								break;
							}
						}

						fsOutput.Flush();
						fsOutput.Close();
					}

					binReader.Close();
				}
			}

			return (0 == nRemaining);
		}

		private byte[] EncryptUsingRSAParam(byte[] abySrcData, RSAParameters rsaPublic)
		{
			byte[] byEncodedData = null;

			using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
			{
				rsa.ImportParameters(rsaPublic);
				byEncodedData = rsa.Encrypt(abySrcData, true);
				rsa.Clear();
			}

			return byEncodedData;
		}

		private byte[] DecryptUsingRSAParam(byte[] abySrcData, RSAParameters rsaPrivate)
		{
			byte[] byDecodedData = null;

			using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
			{
				rsa.ImportParameters(rsaPrivate);
				byDecodedData = rsa.Decrypt(abySrcData, true);
				rsa.Clear();
			}

			return byDecodedData;
		}

		private void OnFindSourceFile(object sender, EventArgs e)
		{
			openSourceDialog.Filter = (radioEncrypt.Checked) ? "Text Files|*.txt|All Files|*.*" : "Encrypted Files|*.enc|All Files|*.*";
			if (DialogResult.OK == openSourceDialog.ShowDialog())
				txtSource.Text = openSourceDialog.FileName;
		}

		private void OnFindDestFile(object sender, EventArgs e)
		{
			saveDestDialog.Filter = (radioEncrypt.Checked) ? "Encrypted Files|*.enc|All Files|*.*" : "Text Files|*.txt|All Files|*.*";
			if (DialogResult.OK == saveDestDialog.ShowDialog())
				txtDest.Text = saveDestDialog.FileName;
		}

		private void OnRadioEncryptChanged(object sender, EventArgs e)
		{
			String sTemp = txtSource.Text;
			txtSource.Text = txtDest.Text;
			txtDest.Text = sTemp;
		}

		public void AssignNewKey()
		{
			const int PROVIDER_RSA_FULL = 1;

			CspParameters cspParams = new CspParameters(PROVIDER_RSA_FULL);
			cspParams.KeyContainerName = CONTAINER_NAME;
			cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
			cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";

			rsa = new RSACryptoServiceProvider(cspParams);

			//Pair of public and private key as XML string.
			//Do not share this to other party
			publicPrivateKeyXML = rsa.ToXmlString(true);

			//Private key in xml file, this string should be share to other parties
			publicOnlyKeyXML = rsa.ToXmlString(false);
		}

		RSACryptoServiceProvider rsa = null;
		String publicPrivateKeyXML;
		String publicOnlyKeyXML;

		private const String CONTAINER_NAME = "MyKeyContainer";
		private byte[] PublicKey = 
			{
				214,46,220,83,160,73,40,39,201,155,19,202,3,11,191,178,56,
				74,90,36,248,103,18,144,170,163,145,87,54,61,34,220,222,
				207,137,149,173,14,92,120,206,222,158,28,40,24,30,16,175,
				108,128,35,230,118,40,121,113,125,216,130,11,24,90,48,194,
				240,105,44,76,34,57,249,228,125,80,38,9,136,29,117,207,139,
				168,181,85,137,126,10,126,242,120,247,121,8,100,12,201,171,
				38,226,193,180,190,117,177,87,143,242,213,11,44,180,113,93,
				106,99,179,68,175,211,164,116,64,148,226,254,172,147
			};

		private byte[] Exponent = { 1, 0, 1 };

		private const Int32 BUFFER_SIZE = 4 * 4;    // 16 byte buffer
	}
}
