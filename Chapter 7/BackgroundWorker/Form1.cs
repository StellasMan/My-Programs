using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BkWorkerTest
{
	public partial class BkGrndWorkerForm : Form
	{
		public BkGrndWorkerForm()
		{
			InitializeComponent();

			m_bkWorker = new BackgroundWorker();
			m_bkWorker.DoWork += BkWorkerThread;
			m_bkWorker.ProgressChanged += BkWorkerProgressChanged;
			m_bkWorker.WorkerReportsProgress = true;
			m_bkWorker.WorkerSupportsCancellation = true;
			m_bkWorker.RunWorkerCompleted += BkWorkerCompleted;

			prgProgress.Minimum = 0;
			prgProgress.Maximum = 100;
			prgProgress.Style = ProgressBarStyle.Blocks;

			btnCancel.Enabled = false;
		}

		private void OnStart(object sender, EventArgs e)
		{
			btnCancel.Enabled = true;
			btnStart.Enabled = false;

			m_bkWorker.RunWorkerAsync();
		}

		private void BkWorkerThread(Object objSender, DoWorkEventArgs eArgs)
		{
			BackgroundWorker bkWorker = objSender as BackgroundWorker;
			if (bkWorker != null)
			{
				for (int nIx = 0; nIx < 100; nIx++)
				{
					System.Threading.Thread.Sleep(200);
					bkWorker.ReportProgress(nIx+1);

					if (bkWorker.CancellationPending)
						break;
				}
			}
		}

		private void BkWorkerProgressChanged(object sender, ProgressChangedEventArgs pceArgs)
		{
			prgProgress.Value = pceArgs.ProgressPercentage;
			prgProgress.Text = String.Format("{0} percent complete", pceArgs.ProgressPercentage);
		}

		private void BkWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnCancel.Enabled = false;
			btnStart.Enabled = true;
			System.Diagnostics.Trace.WriteLine("BkWorker Completed");
		}

		private void OnCancel(object sender, EventArgs e)
		{
			if (!m_bkWorker.CancellationPending)
				m_bkWorker.CancelAsync();
		}

		private BackgroundWorker m_bkWorker;
	}
}
