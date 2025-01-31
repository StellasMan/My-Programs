using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BkGroundTest
{
	public partial class BkGroundForm : Form
	{
		private bool m_bIsRunning = false;
		private bool m_bCancelPending = false;
		private LinkedList<BackgroundWorkerNumbered> m_lstBkBkWorker = new LinkedList<BackgroundWorkerNumbered>();
		private Random rnd = new Random(DateTime.Now.Millisecond);
		private System.Windows.Forms.Timer tmTimer = new System.Windows.Forms.Timer();
		private Int32[] m_anPctComplete;

		public BkGroundForm()
		{
			InitializeComponent();

			tmTimer.Interval = 5000;
			tmTimer.Tick += OnTimerTick;

			ListView.ColumnHeaderCollection lvHdrCollection = lvStatus.Columns;
			ColumnHeader colHdrStatus = lvHdrCollection[1];
		}

		private void OnTimerTick(Object sender, EventArgs e)
		{
			tmTimer.Stop();
		}

		private void OnStartStop(Object sender, EventArgs e)
		{
			if (m_bIsRunning)
			{
				DoStop();
			}
			else
			{
				m_bIsRunning = true;
				btnStartStop.Text = "&Stop";
				lvStatus.Items.Clear();
				DoStart();
			}
		}

		private void DoStart()
		{
			lvStatus.Items.Clear();
			m_anPctComplete = new Int32[(int)nudThreads.Value];
			nudThreads.Enabled = false;

			txtTotComplete.Text = "0";
			txtAvgPct.Text = "0.0";
			m_lstBkBkWorker.Clear();

			for (int nIx=0; nIx<(int)nudThreads.Value; nIx++)
			{
				int nRandom = rnd.Next(15, 50);
				BackgroundWorkerNumbered bkWorkerItem = new BackgroundWorkerNumbered(nIx+1);

				bkWorkerItem.WorkerSupportsCancellation = true;
				bkWorkerItem.WorkerReportsProgress = true;
				bkWorkerItem.ProgressChanged += RunBkWorkerProgressChanged;
				bkWorkerItem.RunWorkerCompleted += RunBkWorkerCompleted;
				bkWorkerItem.DoWork += RunBkThread;
				m_lstBkBkWorker.AddLast(bkWorkerItem);

				bkWorkerItem.RunWorkerAsync(new Object[] { nRandom });
			}
		}

		private void DoStop()
		{
			if (!m_bCancelPending)
			{
				m_bCancelPending = true;
				foreach (BackgroundWorker bkItem in m_lstBkBkWorker)
				{
					if (bkItem.IsBusy && !bkItem.CancellationPending)
						bkItem.CancelAsync();
				}
			}
		}

		private void RunBkThread(Object Sender, DoWorkEventArgs e)
		{
			BackgroundWorkerNumbered bkWorkerItem = Sender as BackgroundWorkerNumbered;

			if (bkWorkerItem != null)
			{
				Object[] objParams = (Object[])e.Argument;
				int nSteps = (int)objParams[0];

				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (int nIx = 0; nIx < nSteps; nIx++)
				{
					Thread.Sleep(250);
					int nPctComplete = (int)Math.Round((double)(nIx * 100) / nSteps);
					bkWorkerItem.ReportProgress(nPctComplete, bkWorkerItem.WorkerID);
					Trace.WriteLine(String.Format("Thread {0}: Completed step {1} of {2}", bkWorkerItem.WorkerID, nIx + 1, nSteps));
					if (bkWorkerItem.CancellationPending)
					{
						Trace.WriteLine(String.Format("Cancelling execution of thread {0}", bkWorkerItem.WorkerID));
						Thread.Sleep(500);
						break;
					}
				}

				stopwatch.Stop();
				TimeSpan time = stopwatch.Elapsed;
				Int32 nTime = (Int32)Math.Round(time.TotalMilliseconds);
				e.Result = new Object[] { nTime };
			}
		}

		private void RunBkWorkerProgressChanged(Object sender, ProgressChangedEventArgs evtArgs)
		{
			int nPctComplete = evtArgs.ProgressPercentage;
			int nThread = (int)evtArgs.UserState;
			if (nThread <= m_anPctComplete.GetLength(0))
				m_anPctComplete[nThread - 1] = nPctComplete;
			double dblTotPctComplete = m_anPctComplete.Average();
			txtAvgPct.Text = String.Format("{0:0.0}", dblTotPctComplete);

			ListViewItem lvItem = new ListViewItem(String.Format("Thread {0}", nThread));
			lvItem.SubItems.Add(String.Format("{0} percent complete", nPctComplete));
			lvStatus.Items.Add(lvItem);
		}

		private void RunBkWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			BackgroundWorkerNumbered bkWorkerNumbered = sender as BackgroundWorkerNumbered;

			if (bkWorkerNumbered != null)
			{
				Int32 nTimeInMs = (Int32)((Object[])e.Result)[0];
				ListViewItem lvItem = new ListViewItem(String.Format("Thread {0}", bkWorkerNumbered.WorkerID));
				lvItem.SubItems.Add(String.Format("Completed in {0} ms", nTimeInMs));
				lvStatus.Items.Add(lvItem);

				m_lstBkBkWorker.Remove(bkWorkerNumbered);

				int nThread = bkWorkerNumbered.WorkerID;
				if (nThread <= m_anPctComplete.GetLength(0))
					m_anPctComplete[nThread - 1] = 100;
				double dblTotPctComplete = m_anPctComplete.Average();
				txtAvgPct.Text = String.Format("{0:0.0}", dblTotPctComplete);

				int nTotComplete = (int)nudThreads.Value - m_lstBkBkWorker.Count;
				txtTotComplete.Text = String.Format("{0}", nTotComplete);

				if (m_lstBkBkWorker.Count == 0)
				{
					m_bIsRunning = false;
					m_bCancelPending = false;
					nudThreads.Enabled = true;

					txtAvgPct.Text = String.Format("{0:0.0}", 100.0);

					btnStartStop.Text = "&Start";
				}
			}
		}
	}
}
