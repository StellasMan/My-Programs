using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

using UtilLib;

namespace StressTest
{
	public partial class FormStress : Form
	{
		const long TICKS_PER_SECOND = 10 * 1000 * 1000;

		Object objThreadSync = new object();
		private bool m_bExitThread = false;
		private bool m_bStarted = false;

		private System.Windows.Forms.Timer m_tmTimer = new System.Windows.Forms.Timer();
		private int m_nActiveThreads = 0;

		private LinkedList<Thread> m_thrdList = new LinkedList<Thread>();

		public FormStress()
		{
			InitializeComponent();

			txtRunTime.Text = "30";
			FormClosing += ThreadingFormClosing;
			SetTimer();
		}

		private void ThreadingFormClosing(object sender, FormClosingEventArgs e)
		{
			StopThreads();

			lock (objThreadSync)
			{
				m_tmTimer.Stop();
			}
		}

		private void SetTimer()
		{
			m_tmTimer.Tick += new EventHandler(OnTimedEvent);

			// Sets the timer interval to 1 seconds.
			m_tmTimer.Interval = 1000;
			m_tmTimer.Start();
		}

		private void OnTimedEvent(Object source, EventArgs e)
		{
			lock (objThreadSync)
			{
				List<Int32> lstCPUs = UtilityClass.GetCPUPerformance();
				Int32 nAvg = (Int32)(Math.Round(lstCPUs.Average()));

				this.Invoke(new Action<int>(ShowStatus), nAvg);
			}
		}

		private void DisplayCPUUsage(int nPercent)
		{
			String csUsage = String.Format("{0}%", nPercent);
			UtilityClass.DisplayTextImmediate(txtCPUUsage, csUsage);
		}

		private void OnStart(object sender, EventArgs e)
		{
			if (!m_bStarted)
			{
				StartThreads();
			}
			else
			{
				StopThreads();
			}
		}

		private void StartThreads()
		{
			m_bStarted = true;
			btnStart.Text = "&Stop";
			txtRunTime.ReadOnly = true;
			int nRunTime = 0;
			if (!Int32.TryParse(txtRunTime.Text, out nRunTime) || (nRunTime < 5))
				nRunTime = 30;
			txtRunTime.Text = String.Format("{0}", nRunTime);

			ThreadPriority thrdPriority =
				radioLowest.Checked			? ThreadPriority.Lowest			:
				radioBelowNormal.Checked	? ThreadPriority.BelowNormal	:
				radioNormal.Checked			? ThreadPriority.Normal			:
				radioAboveNormal.Checked	? ThreadPriority.AboveNormal	: ThreadPriority.Highest;

			// Separate thread, but runs in context of containing scope
			Thread thrdStarter = new Thread
				(() =>
					{
						int nCPUs = Environment.ProcessorCount;
						for (int nIx = 0; nIx < nCPUs; nIx++)
						{
							Thread thrdStress = new Thread(CPUStressThread);
							thrdStress.Name = String.Format("Thread{0}", nIx + 1);
							thrdStress.Priority = thrdPriority;
							m_thrdList.AddLast(thrdStress);

							thrdStress.Start(nRunTime);
							Thread.Sleep(500);
						}
					}
				);

			m_thrdList.Clear();
			m_bExitThread = false;
			thrdStarter.Start();
		}

		private void StopThreads()
		{
			m_bExitThread = true;
			JoinThreads();

			m_bStarted = false;
			txtRunTime.ReadOnly = false;
			btnStart.Text = "&Start";
		}

		private void JoinThreads()
		{
			try
			{
				Trace.WriteLine("Stopping threads");
				foreach (Thread thrd in m_thrdList)
				{
					if (thrd.IsAlive)
					{
						thrd.Join(TimeSpan.FromSeconds(5));
						if (thrd.IsAlive)
						{
							thrd.Abort();
						}
					}
				}
			}
			catch (System.Threading.ThreadAbortException ex)
			{
				Trace.WriteLine(String.Format("{0}", ex.Message));
			}
		}

		void CPUStressThread(Object objCount)
		{
			int nSecondsToRun = (int)objCount;
			String sThreadName = Thread.CurrentThread.Name;
			Console.WriteLine(String.Format("**** Starting loop for thread {0}; (Running for {1} seconds) ****", sThreadName, nSecondsToRun));

			Interlocked.Increment(ref m_nActiveThreads);

			// Busy loop for 'nSecondsToRun' seconds
			DateTime dtStart = DateTime.Now;
			while (!m_bExitThread)
			{
				long lTicks = (DateTime.Now.Ticks - dtStart.Ticks);
				Math.Sqrt(lTicks / Math.PI);    // Occupies floating point processor
				if (lTicks >= (nSecondsToRun * TICKS_PER_SECOND))   // 10 million ticks per second
					break;
			}

			Console.WriteLine(String.Format("**** Loop for thread {0} Complete ****", sThreadName));
			Interlocked.Decrement(ref m_nActiveThreads);
		}

		private void ShowStatus(int nCPUUsage)
		{
			UtilityClass.DisplayTextImmediate(txtPooledActive, String.Format("{0}", m_nActiveThreads));

			String csUsage = String.Format("{0}%", nCPUUsage);
			UtilityClass.DisplayTextImmediate(txtCPUUsage, csUsage);

			if (m_bStarted && (m_nActiveThreads == 0))
				StopThreads();
		}
	}
}
