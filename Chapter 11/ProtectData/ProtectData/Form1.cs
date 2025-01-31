using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtectData
{
	public partial class ProtectDataMainForm : Form
	{
		public ProtectDataMainForm()
		{
			InitializeComponent();

			radioEncrypt.Checked = true;
			radioDecrypt.Checked = false;
		}

		private void OnFindDecryptSrc(object sender, EventArgs e)
		{
			dlgOpenFile.Filter = (radioEncrypt.Checked) ? "Text Files|*.txt|All Files|*.*" : "Encrypted Files|*.enc|All Files|*.*";
			if (DialogResult.OK == dlgOpenFile.ShowDialog(this))
			{
				txtSrcFile.Text = dlgOpenFile.FileName;
			}
		}

		private void OnFindDecryptDest(object sender, EventArgs e)
		{
			dlgSaveFile.Filter = (radioEncrypt.Checked) ? "Encrypted Files|*.enc|All Files|*.*" : "Text Files|*.txt|All Files|*.*";
			if (DialogResult.OK == dlgSaveFile.ShowDialog(this))
			{
				txtDestFile.Text = dlgSaveFile.FileName;
			}
		}

		private void OnEncryptDecryptChanged(object sender, EventArgs e)
		{
			btnEncryptDecrypt.Text = (radioEncrypt.Checked) ? "En&crypt" : "De&crypt";
			grpEncrypt.Text = (radioEncrypt.Checked) ? "Encrypt" : "Decrypt";
		}

		private void OnEncryptDecrypt(object sender, EventArgs e)
		{
			String srcFile = txtSrcFile.Text;
			String destFile = txtDestFile.Text;

			if (!File.Exists(srcFile))
			{
				MessageBox.Show(String.Format("Source File {0} does not exist", srcFile), "Error", MessageBoxButtons.OK);
			}
			else
			{
				EncryptDecryptData(srcFile, destFile, radioEncrypt.Checked);
			}
		}

		// **************************************************************************************
		// ************ This version uses BinaryWriter to output the encrypted bytes ************
		// **************************************************************************************

		//void EncryptData(String sSrcFile, String sDestFile)
		//{
		//	FileInfo filInfo = new FileInfo(sSrcFile);
		//	Int64 nRemaining = filInfo.Length;
		//	using (FileStream fs = File.OpenRead(sSrcFile))
		//	{
		//		using (BinaryWriter writer = new BinaryWriter(File.Open(sDestFile, FileMode.Create)))
		//		{
		//			Int64 nRead = 0;

		//			while (nRemaining > 0)
		//			{
		//				Int64 nBufSize = Math.Min(BUFFER_SIZE, nRemaining);
		//				byte[] abyPlainText = new byte[nBufSize];
		//				if ((nRead = fs.Read(abyPlainText, 0, (int)nBufSize)) > 0)
		//				{
		//					byte[] byEncrypted = ProtectedData.Protect(abyPlainText, null, DataProtectionScope.CurrentUser);
		//					writer.Write(byEncrypted);
		//					nRemaining -= nRead;
		//				}
		//			}

		//			writer.Close();
		//		}

		//		fs.Close();
		//	}
		//}

		// ************************************************************************************
		// ************ This version uses FileStream to output the encrypted bytes ************
		// ************************************************************************************
		void EncryptDecryptData(String sSrcFile, String sDestFile, bool bEncrypt)
		{
			FileInfo filInfo = new FileInfo(sSrcFile);
			Int64 nRemaining = filInfo.Length;
			byte[] abyInputData = new byte[BUFFER_SIZE];

			try
			{
				using (FileStream fsReader = File.OpenRead(sSrcFile))
				{
					byte[] abyAdditionalEntropy = { 9, 8, 7, 6, 5 };
					using (FileStream fsWriter = File.OpenWrite(sDestFile))
					{
						Int64 nRead = 0;

						while (nRemaining > 0)
						{
							Int64 nBufSize = Math.Min(BUFFER_SIZE, nRemaining);
							if (nBufSize < BUFFER_SIZE)
								abyInputData = new byte[nBufSize];

							if ((nRead = fsReader.Read(abyInputData, 0, (int)nBufSize)) > 0)
							{
								byte[] byTransformed = (bEncrypt) 
											? ProtectedData.Protect(abyInputData, abyAdditionalEntropy, DataProtectionScope.CurrentUser) 
											: ProtectedData.Unprotect(abyInputData, abyAdditionalEntropy, DataProtectionScope.CurrentUser);

								fsWriter.Write(byTransformed, 0, (int)nRead);
								nRemaining -= nRead;
							}
						}

						fsWriter.Flush();
						fsWriter.Close();
					}

					fsReader.Close();
				}
			}

			catch(System.IO.IOException ioExc)
			{
				String sError = String.Format("I/O error attempting to read or write data.\n{0}", ioExc.Message);
				MessageBox.Show(sError, "Error", MessageBoxButtons.OK);
			}

			catch (System.Security.Cryptography.CryptographicException cryExc)
			{
				String sError = String.Format("Error {0} data.\n{1}", bEncrypt ? "encrypting" : "decrypting", cryExc.Message);
				MessageBox.Show(sError, "Error", MessageBoxButtons.OK);
			}
		}

		const int BUFFER_SIZE = 4*1024*1024;	// 4Mb
	}
}
