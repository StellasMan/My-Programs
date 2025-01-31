using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueTasks
{
	public partial class ContinueTaskForm : Form
	{
		public ContinueTaskForm()
		{
			InitializeComponent();

			m_tmTimer.Interval = 200;
			m_tmTimer.Tick += new EventHandler(ProcessTimerTick);
			m_tmTimer.Enabled = false;
		}

		private void OnStart(object sender, EventArgs e)
		{
			if (!m_bRunning)
			{
				DoStart();
			}
			else
			{
				DoStop();
			}
		}

		private void DoStart()
		{
			int nTasks = (int)nudTasks.Value;
			m_llistTasks.Clear();
			m_bRunning = true;
			btnStart.Text = "&Stop";
			rtxtStatus.Clear();

			m_nThreadID = 0;
			m_nQueued = nTasks;
			m_nRunning = 0;
			m_nComplete = 0;

			m_tmTimer.Enabled = true;
			m_tmTimer.Start();

			if (m_canCancelTknSrc != null)
				m_canCancelTknSrc.Dispose();

			m_canCancelTknSrc = new CancellationTokenSource();

			for (int nIx=0; nIx<nTasks; nIx++)
			{
				CancellationToken canCancelled = m_canCancelTknSrc.Token;
				Task<double> tskItem = Task.Run(() => DoIntensiveCalcs(canCancelled), canCancelled);
				m_llistTasks.AddLast(tskItem);
			}

			Action<Task<double>[]> actFinal = new Action<Task<double>[]>((Task<double>[] atskTasks) => ContinueAfterAll(atskTasks));

			Task tskFinal = Task.Factory.ContinueWhenAll<double>(m_llistTasks.ToArray(), actFinal);
		}

		private void DoStop()
		{
			m_canCancelTknSrc.Cancel();
		}

		private double DoIntensiveCalcs(CancellationToken canCancelled)
		{
			String szMsg;
			int nThreadID = 0;
			int nQueued = 0;
			int nRunning = 0;
			int nComplete = 0;

			lock (m_objLock)
			{
				nThreadID = ++m_nThreadID;
				nQueued = --m_nQueued;
				nRunning = ++m_nRunning;
			}

			Thread thrdCurrent = Thread.CurrentThread;
			thrdCurrent.Name = String.Format("Thread {0}", nThreadID);

			szMsg = String.Format("Starting Thread {0:D}\n", nThreadID);
			Trace.Write(szMsg);
			m_qstrMessages.Enqueue(szMsg);

			double dblResult = 0;

			Stopwatch stStopWatch = new Stopwatch();
			stStopWatch.Start();

			Random rand = new Random(nThreadID);

			double[] dblArrResults = new double[5000];
			for (int nIx = 0; !canCancelled.IsCancellationRequested && (nIx < 5000); nIx++)
			{
				try
				{
					double dblInterim = 0;
					int nMax = rand.Next(5000, 100000);
					for (int nIy = 1; !canCancelled.IsCancellationRequested && (nIy <= nMax); nIy++)
					{
						dblInterim += Math.Sqrt(nIy);
					}
					dblArrResults[nIx] = dblInterim;
				}

				catch (Exception ex)
				{
					Trace.WriteLine(String.Format("Exception: {0}", ex.Message));
				}
			}

			dblResult = dblArrResults.Average();
			stStopWatch.Stop();

			szMsg = String.Format("                      Thread {0:D} required {1:D6} msecs to execute; Result={2:N3}\n", nThreadID, stStopWatch.ElapsedMilliseconds, dblResult);
			Trace.Write(szMsg);
			m_qstrMessages.Enqueue(szMsg);

			lock (m_objLock)
			{
				nRunning = --m_nRunning;
				nComplete = ++m_nComplete;
			}

			return dblResult;
		}

		private void ProcessTimerTick(Object myObject, EventArgs myEventArgs)
		{
			int nQueued = 0;
			int nRunning = 0;
			int nComplete = 0;

			lock (m_objLock)
			{
				nQueued = m_nQueued;
				nRunning = m_nRunning;
				nComplete = m_nComplete;
			}

			txtQueued.Text = String.Format("{0}", nQueued);
			txtRunning.Text = String.Format("{0}", nRunning);
			txtComplete.Text = String.Format("{0}", nComplete);

			String szStatus;
			if (m_qstrMessages.TryDequeue(out szStatus))
				rtxtStatus.Text += szStatus;
		}

		private void ContinueAfterAll(Task<double>[] atskTasks)
		{
			m_bRunning = false;
			double dblResult = 0;
			int nCount = 0;

			Action actDone = new Action
			(
				() =>
				{
					String szMsg;

					btnStart.Text = "&Start";
					m_bRunning = false;
					m_tmTimer.Enabled = false;
					btnStart.Text = "&Start";

					while (m_qstrMessages.TryDequeue(out szMsg))
						rtxtStatus.Text += szMsg;

					String szAsterisk = new string('*', 50) + "\n";
					Trace.Write(szAsterisk);
					rtxtStatus.Text += szAsterisk;

					szMsg = String.Format("Result of calculations: {0:N3}\n", dblResult);
					Trace.Write(szMsg);
					rtxtStatus.Text += szMsg;

					Trace.Write(szAsterisk);
					rtxtStatus.Text += szAsterisk;

					foreach (Task tskItem in atskTasks)
					{
						szMsg = String.Format("Task {0,3:D} status: {1}\n", tskItem.Id, tskItem.Status.ToString());
						Trace.Write(szMsg);
						rtxtStatus.Text += szMsg;
					}

					txtQueued.Text = String.Format("{0}", m_nQueued);
					txtRunning.Text = String.Format("{0}", m_nRunning);
					txtComplete.Text = String.Format("{0}", m_nComplete);
				}
			);

			foreach (Task<double> tskItem in atskTasks)
			{
				if (tskItem.Status == TaskStatus.Canceled)
				{
					m_nQueued--;
				}
				else
				{
					dblResult += tskItem.Result;
					nCount++;
				}
			}

			dblResult /= nCount;
			if (InvokeRequired)
			{
				Invoke(actDone);
			}
			else
			{
				actDone();
			}
		}

		private int m_nQueued = 0;
		private int m_nRunning = 0;
		private int m_nComplete = 0;
		private int m_nThreadID = 0;

		private Object m_objLock = new Object();
		private bool m_bRunning = false;

		ConcurrentQueue<String> m_qstrMessages = new ConcurrentQueue<String>();
		CancellationTokenSource m_canCancelTknSrc = null;

		private LinkedList<Task<double>> m_llistTasks = new LinkedList<Task<double>>();
		System.Windows.Forms.Timer m_tmTimer = new System.Windows.Forms.Timer();
	}
}
