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

using UtilLib;

namespace ParallelLibApp
{
	public partial class Form1 : Form
	{
		const uint ITERATION_COUNT = 32;
		const uint TICKS_PER_SEC = 10 * 1000 * 1000;
		private AutoResetEvent m_autoResetEvent = new AutoResetEvent(false);
		private long m_lStartTicks;

		private LinkedList<Task<double>> m_lstTasks = new LinkedList<Task<double>>();

		public Form1()
		{
			InitializeComponent();

			ThreadPool.SetMaxThreads(32, 32);

			System.Windows.Forms.Timer tmTimer = new System.Windows.Forms.Timer();
			tmTimer.Tick += new EventHandler(ShowThreadCount);

			// Sets the timer interval to .5 seconds.
			tmTimer.Interval = 500;
			tmTimer.Start();
		}

		private void OnSynchronous(object sender, EventArgs e)
		{
			double dResult = 0.0;

			UtilityClass.DisplayTextImmediate(txtTime, "");
			UtilityClass.DisplayTextImmediate(txtResults, "");

			Cursor curSaved = System.Windows.Forms.Cursor.Current;
			System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

			long lStartTicks = DateTime.Now.Ticks;
			for (uint uiIx = 0; uiIx < ITERATION_COUNT; uiIx++)
			{
				dResult += UtilLib.UtilityClass.DoIntensiveCalculations();
			}

			System.Windows.Forms.Cursor.Current = curSaved;

			double dSecs = ((double)(DateTime.Now.Ticks - lStartTicks)) / TICKS_PER_SEC;
			Trace.WriteLine(String.Format("Calculation required {0} seconds to complete", dSecs));

			UtilityClass.DisplayTextImmediate(txtTime, String.Format("{0:N3} seconds", dSecs));
			UtilityClass.DisplayTextImmediate(txtResults, String.Format("{0:N2}", dResult));
		}

		private void ShowThreadCount(Object sender, EventArgs e)
		{
			ThreadPool.GetMaxThreads(out int nMaxWorkers, out int nMaxPorts);
			ThreadPool.GetAvailableThreads(out int nWorkers, out int nPorts);
			txtAvailable.Text = String.Format("{0}", nWorkers);
			txtActive.Text = String.Format("{0}", nMaxWorkers - nWorkers);
		}

		private void OnParallel(object sender, EventArgs e)
		{
			btnParallel.Enabled = false;

			m_lstTasks.Clear();

			UtilityClass.DisplayTextImmediate(txtTime, "");
			UtilityClass.DisplayTextImmediate(txtResults, "");

			m_lStartTicks = DateTime.Now.Ticks;
			for (uint uiIx = 0; uiIx < ITERATION_COUNT; uiIx++)
			{
				//Task<double> tskItem = new Task<double>(() =>
				//	{
				//		double dblValue = UtilLib.UtilityClass.DoIntensiveCalculations();
				//		m_autoResetEvent.Set();
				//		return dblValue;
				//	}
				//);

				Task<double> tskItem = new Task<double>(new Func<double>(UtilLib.UtilityClass.DoIntensiveCalculations));
				m_lstTasks.AddLast(tskItem);

				tskItem.Start();
			}

			System.Threading.Tasks.TaskFactory tskFactory = new TaskFactory();
			tskFactory.ContinueWhenAll(m_lstTasks.ToArray(), TasksComplete);
		}

		private void ThreadMonitor(AutoResetEvent autoEvent, Action eventHandler)
		{
			while (true)
			{
				autoEvent.WaitOne();
				if (this.InvokeRequired)
				{
					this.Invoke(eventHandler);
				}
				else
				{
					eventHandler();
				}
			}
		}

		void TasksComplete(Task<double>[] aTasks)
		{
			long lTicksElapsed = DateTime.Now.Ticks-m_lStartTicks;
			double dblResult = 0d;
			foreach (var itemTask in aTasks)
			{
				if (!itemTask.IsFaulted && !itemTask.IsCanceled)
					dblResult += itemTask.Result;
			}

			Trace.WriteLine(String.Format("{0:N2}", dblResult));
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<double, long>(DisplayResults), dblResult, lTicksElapsed);
			}
			else
			{
				DisplayResults(dblResult, lTicksElapsed);
			}
		}

		void DisplayResults(double dResults, long lTicksElapsed)
		{
			double dSecs = (double)lTicksElapsed / TICKS_PER_SEC;
			UtilityClass.DisplayTextImmediate(txtTime, String.Format("{0:N3} seconds", dSecs));
			UtilityClass.DisplayTextImmediate(txtResults, String.Format("{0:N2}", dResults));

			btnParallel.Enabled = true;
			btnParallel.Focus();
		}

		// ****************************************************************************
		// Task 'Continue' testing
		// ****************************************************************************
		private void OnContinue(object sender, EventArgs e)
		{
			btnContinue.Enabled = false;

			Task tskThread = new Task(() =>
				{
					Task tskStep1 = new Task(new Action(Action1));
					Task tskStep2 = new Task(new Action(Action2));
					// Task tskStep3 = tskStep1.ContinueWith((previousTask) => Action3(previousTask));
					Task tskStep3 = tskStep1.ContinueWith(new Action<Task>(Action3));

					tskStep1.Start();
					tskStep2.Start();

					Task[] tskAll = new Task[] { tskStep1, tskStep2, tskStep3 };
					Task.WaitAll(tskAll);
				}
			);

			tskThread.Start();
		}

		private void BusyDelay(Object objParam)
		{
			int nSecs = (int)objParam;
			long lTicks = DateTime.Now.Ticks;
			Random rand = new Random();

			while (true)
			{
				int nValue = rand.Next(2000, 10000);
				Math.Sqrt(nValue);
				if ((DateTime.Now.Ticks - lTicks) >= (nSecs * TICKS_PER_SEC))
					break;
			}
		}

		private void Action1()
		{
			BusyDelay(5);
			Trace.WriteLine(String.Format("Action1 complete"));
		}

		private void Action2()
		{
			BusyDelay(5);
			Trace.WriteLine(String.Format("Action2 complete"));
		}

		private void Action3(Task tskPrevious)
		{
			BusyDelay(3);
			Trace.WriteLine(String.Format("Action3 complete"));

			this.BeginInvoke(new Action(() =>
			{
				btnContinue.Enabled = true;
				btnContinue.Focus();
			}
			));
		}

		private void OnBackGround(object sender, EventArgs e)
		{
			BackgroundWorker bkWorker = new BackgroundWorker();
			bkWorker.DoWork += BkWorker_DoWork;
			bkWorker.RunWorkerCompleted += BkWorker_RunWorkerCompleted;

			bkWorker.RunWorkerAsync();
			btnBackground.Enabled = false;
		}

		private void BkWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			BusyDelay(10);
		}

		private void BkWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnBackground.Enabled = true;
		}

		private void OnThreads(object sender, EventArgs e)
		{
			for (int nIx=0; nIx<4; nIx++)
			{
				Thread thrdItem = new Thread(new ParameterizedThreadStart(BusyDelay));
				thrdItem.IsBackground = true;
				thrdItem.Start(10);
			}
		}
	}
}
