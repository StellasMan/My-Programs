using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BackgroundApp
{
    public partial class Form1 : Form
    {
        const long TICKSPERSECOND = 10000000;

        BackgroundWorker m_bkWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();

            m_bkWorker.WorkerSupportsCancellation = true;
            m_bkWorker.WorkerReportsProgress = true;
            m_bkWorker.DoWork += DoBkWorkEvent;
            m_bkWorker.ProgressChanged += BkProgressChangedEvent;
            m_bkWorker.RunWorkerCompleted += RunBkWorkerCompletedEvent;
        }

        private void OnStartOrCancel(object sender, EventArgs e)
        {
            if (!m_bkWorker.IsBusy)
            {
                QuerySecondsDlg dlgQuery = new QuerySecondsDlg();
                DialogResult dlgRes = dlgQuery.ShowDialog();
                if (dlgRes == DialogResult.OK)
                {
                    uint uiSeconds = dlgQuery.m_uiSeconds;
                    btnStartOrCancel.Text = "C&ancel";
                    m_bkWorker.RunWorkerAsync(uiSeconds);
                }
            }
            else if (!m_bkWorker.CancellationPending)
            {
                m_bkWorker.CancelAsync();
            }
        }

        private void DoBkWorkEvent(object sender, DoWorkEventArgs e)
        {
            uint uiSeconds = 0;
            uint uiSecondsTotal = (uint)e.Argument;
            for (uint uiIx=0; uiIx<uiSecondsTotal; uiIx++)
            {
                // Busy loop for 1 second
                long lTicksStart = DateTime.Now.Ticks;
                while (true)
                {
                    if (m_bkWorker.CancellationPending)
                        break;

                    long lTicksNow = DateTime.Now.Ticks;
                    if ((lTicksNow-lTicksStart) >= TICKSPERSECOND)
                    {
                        uiSeconds++;
                        int nPct = (int)Math.Round((100.0 * uiSeconds) / uiSecondsTotal);
                        m_bkWorker.ReportProgress(nPct);

                        break;
                    }
                }
            }
        }

        private void BkProgressChangedEvent(object sender, ProgressChangedEventArgs e)
        {
            txtStatus.Text = String.Format("Background thread is {0}% complete", e.ProgressPercentage);
        }

        private void RunBkWorkerCompletedEvent(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStartOrCancel.Text = "St&art";
        }
    }

	public class ItemData
	{
		ItemData()
		{

		}

		public String m_sFirstName = "Jeff";
		public String m_sLastName = "Armstrong";
		public String m_sSpouse= "Stella";

		protected String m_sEmployer = "Deltek";

		private int m_nAge = 65;
	}
}
