using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PoolTest
{
	public partial class PoolTestForm : Form
	{
		bool	m_bStarted = false;
		Random	m_Random = new Random(DateTime.Now.Millisecond);
		Int32	m_nThreadID = 0;
		bool	m_bQuit = false;   // Set to true when we want all threads to exit

		System.Windows.Forms.Timer m_timerStatus = new System.Windows.Forms.Timer();
		delegate void FinishedDelegate(Int32 nThreadID);

		static Object m_LockingVar = new Object();

		// The following variables are modified between threads.
		// Any modification must be done inside of a lock(m_LockingVar) statement.
		static Int32 m_nRunningThreads = 0; // Shared between threads
		static Int32 m_nQueuedThreads = 0; // Shared between threads

		public PoolTestForm()
		{
			InitializeComponent();

			int nWorkerThreads;
			int nIOThreads;
			int nMaxThreads;

			ThreadPool.GetAvailableThreads(out nWorkerThreads, out nIOThreads);
			nMaxThreads = Math.Min(100, nWorkerThreads);
			txtAvailable.Text = String.Format("{0}", nMaxThreads);

			txtRunning.Text = "0";

			numAllowed.Minimum = Environment.ProcessorCount;
			numAllowed.Maximum = nMaxThreads;
			numAllowed.Value = Environment.ProcessorCount;

			numDesired.Minimum = 1;
			numDesired.Maximum = nMaxThreads;
			numDesired.Value = 1;

			m_timerStatus.Tick += new EventHandler(TimerCallbackMethod);

			// Sets the timer interval to .5 seconds.
			m_timerStatus.Interval = 500;
		}

		void UpdatePoolCount(bool bIncrement)
		{
			lock (m_LockingVar)
			{
				if (bIncrement)
				{
					if (m_nQueuedThreads > 0)
						m_nQueuedThreads--;

					m_nRunningThreads++;
				}
				else if (m_nRunningThreads > 0)
				{
					m_nRunningThreads--;
					if (m_nRunningThreads == 0)
						m_bQuit = true;
				}
			}
		}

		void TimerCallbackMethod(Object objState, EventArgs evtArgs)
		{
			int nQueuedThreads = m_nQueuedThreads;
			int nRunningThreads = m_nRunningThreads;

			txtRunning.Text = String.Format("{0}", nRunningThreads);
			txtWaiting.Text = string.Format("{0}", nQueuedThreads);

			int nWorkers, nPorts;
			System.Threading.ThreadPool.GetAvailableThreads(out nWorkers, out nPorts);
			Trace.WriteLine(String.Format("Available threads: {0}", nWorkers));

			// If we're quitting and Pool Count is zero, then kill the timer.
			if (m_bQuit && (nRunningThreads <= 0))
			{
				Trace.WriteLine("Stopping timer");
				m_timerStatus.Stop();

				m_bQuit = false;
				m_bStarted = false;
				numAllowed.Enabled = true;
				numDesired.Enabled = true;
				btnStart.Text = "&Start";
			}
		}

		// Called by the pool threads when the thread has completed.
		void ThreadFinish(Int32 nThreadID)
		{
			Trace.WriteLine(String.Format("Thread {0} ID {1} has completed", nThreadID, Thread.CurrentThread.GetHashCode().ToString()));
		}

		void OnStartStop(object sender, EventArgs e)
		{
			DoStartStop();
		}

		void DoStartStop()
		{ 
			bool bStarted = m_bStarted;

			m_bStarted = !m_bStarted;
			if (bStarted)
			{
				DoStop();
			}
			else
			{
				DoStart();
			}
		}

		public void WaitEventCallback(Object state, bool timedOut)
		{
			ThreadInfo thrdInfo = state as ThreadInfo;
			Trace.WriteLine(String.Format("WaitEventCallback executes in context of thread {0} with ID of {1}", thrdInfo.ThreadID, Thread.CurrentThread.GetHashCode().ToString()));
		}

		void DoStart()
		{
			m_bQuit = false;

			btnStart.Text = "&Stop";
			numAllowed.Enabled = false;
			numDesired.Enabled = false;

			int nMaxThreads = Math.Min(100, Math.Max(Environment.ProcessorCount, (int)numAllowed.Value));
			int nMinThreads = Math.Min(Environment.ProcessorCount, nMaxThreads);
			txtAvailable.Text = String.Format("{0}", nMaxThreads);

			System.Threading.ThreadPool.SetMinThreads(nMinThreads, nMinThreads);
			System.Threading.ThreadPool.SetMaxThreads(nMaxThreads, nMaxThreads);

			Trace.WriteLine(String.Format("Startings threads in context of thread {0}", Thread.CurrentThread.GetHashCode().ToString()));

			m_nThreadID = 0;
			FinishedDelegate finishedCallback = ThreadFinish;
			for (int nIx=0; nIx< numDesired.Value; nIx++)
			{
				int nThreadID = m_nThreadID++;
				AutoResetEvent evAuto = new AutoResetEvent(false);
				ThreadInfo thrdInfo = new ThreadInfo(evAuto, nThreadID);

				lock (m_LockingVar)
				{
					m_nQueuedThreads++;
				}

				Int32 nPeriod = m_Random.Next(5, 15);
				ThreadPool.RegisterWaitForSingleObject(
						evAuto,	
						WaitEventCallback, 
						thrdInfo, 
						-1, 
						true);

				System.Threading.ThreadPool.QueueUserWorkItem(WorkItem, new Object[] { finishedCallback, nPeriod, nThreadID, evAuto });
			}

			m_timerStatus.Start();
		}

		void DoStop()
		{
			m_bQuit = true;
		}

		void WorkItem(Object objParams)
		{
			Object[] aParams = objParams as Object[];
			FinishedDelegate finishedCallback = aParams[0] as FinishedDelegate;
			Int32 nPeriod = (Int32)aParams[1];
			Int32 nThreadID = (Int32)aParams[2];
			AutoResetEvent evAuto = aParams[3] as AutoResetEvent;

			UpdatePoolCount(true);

			Trace.WriteLine(String.Format("Thread {0}, ID {1} starting, Period = {2} seconds", nThreadID, Thread.CurrentThread.GetHashCode().ToString(), nPeriod));

			for (int nIx=0; nIx<nPeriod*10; nIx++)
			{
				Thread.Sleep(100);
				if (m_bQuit)
					break;
			}

			evAuto.Set();	// Signal the event

			if (finishedCallback != null)
			{
				finishedCallback(nThreadID);
			}

			UpdatePoolCount(false);
		}
	}

	public class ThreadInfo
	{
		public ThreadInfo(AutoResetEvent ev, Int32 nThreadID)
		{
			m_autoEvent = ev;
			m_nThreadID = nThreadID;
		}

		public AutoResetEvent AutoEvent
		{
			get { return m_autoEvent; }
		}

		public Int32 ThreadID
		{
			get { return m_nThreadID; }
		}

		private AutoResetEvent m_autoEvent;
		private Int32 m_nThreadID;
	}
}
