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

namespace ThreadPoolTest
{
	public partial class ThreadPoolForm : Form
	{
		public ThreadPoolForm()
		{
			InitializeComponent();

			int nWorkerThreads;
			int nPortThreads;

			ThreadPool.SetMaxThreads(16, 16);
			ThreadPool.GetAvailableThreads(out nWorkerThreads, out nPortThreads);

			txtAvailable.Text = String.Format("{0}", nWorkerThreads);
			txtRunning.Text = "0";
			txtQueued.Text = "0";

			m_timTimer.Tick += new EventHandler(TimerEventProcessor);

			// Sets the timer interval to 5 ticks/second.
			m_timTimer.Interval = 200;
		}

		private void OnStart(object sender, EventArgs e)
		{
			Stopwatch stopWatch = new Stopwatch();
			m_bStop = false;
			for (int nIx=0; nIx<4; nIx++)
			{
				double dblResult = 0d;
				ThreadPool.QueueUserWorkItem((x) => dblResult = ReadDataFromIO());
				lock(m_objRunningThreadsLock)
				{
					m_nQueuedThreads++;
				}
			}

			stopWatch.Reset();
			stopWatch.Start();
			m_autoEvent.Reset(); // Set manual wait event to non-signalled
			m_regWaitHandle = ThreadPool.RegisterWaitForSingleObject(
				m_autoEvent,
				(Obj, bTimedOut) =>
				{
					Trace.WriteLine(String.Format("Callback executed: Time: {0:N1}; TimedOut={1}", stopWatch.ElapsedMilliseconds / 1000.0, bTimedOut ? "True" : "False"));
					if (!bTimedOut)
					{
						m_regWaitHandle.Unregister(m_autoEvent);
					}
				},
				null, 
				new TimeSpan(0, 0, 10), 
				false);

			if (!m_timTimer.Enabled)
			{
				m_timTimer.Start();
				Trace.WriteLine("Timer Started");
			}
		}

		private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			int nWorkerThreadsAvail;
			int nPortThreadsAvail;
			int nWorkerThreadsMax;
			int nPortThreadsMax;
			int nQueuedThreads;

			lock (m_objRunningThreadsLock)
			{
				// Get snapshot of state
				ThreadPool.GetAvailableThreads(out nWorkerThreadsAvail, out nPortThreadsAvail);
				ThreadPool.GetMaxThreads(out nWorkerThreadsMax, out nPortThreadsMax);
				nQueuedThreads = m_nQueuedThreads;
			}

			if (nQueuedThreads == 0)
			{
				System.Windows.Forms.Timer timTimer = myObject as System.Windows.Forms.Timer;
				timTimer.Stop();
				Trace.WriteLine("Timer Stopped");
				m_autoEvent.Set();
			}

			int nRunning = nWorkerThreadsMax - nWorkerThreadsAvail;
			int nQueued = nQueuedThreads - nRunning;

			txtAvailable.Text = String.Format("{0}", nWorkerThreadsAvail);
			txtRunning.Text = String.Format("{0}", nRunning);
			txtQueued.Text = String.Format("{0}", nQueued);
		}

		private double ReadDataFromIO()
		{
			int nCount = m_rndRandom.Next(10000, 100000);

			for (int nIx=0; !m_bStop && (nIx<nCount); nIx++)
			{
				for (int nIy=0; !m_bStop && (nIy<100000); nIy++)
				{
					double dvlValue = Math.Sqrt(nIy + 1);
				}
			}

			lock (m_objRunningThreadsLock)
			{
				if (m_nQueuedThreads > 0)
					m_nQueuedThreads--;
			}

			return 1248.16;
		}

		private void OnStop(object sender, EventArgs e)
		{
			m_bStop = true;
		}

		private System.Windows.Forms.Timer m_timTimer = new System.Windows.Forms.Timer();
		private int m_nQueuedThreads = 0;
		private Object m_objRunningThreadsLock = new Object();
		private Random m_rndRandom = new Random(100);
		bool m_bStop = false;
		AutoResetEvent m_autoEvent = new AutoResetEvent(false);
		RegisteredWaitHandle m_regWaitHandle = null;
	}
}
