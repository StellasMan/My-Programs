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
		static Int32 m_nPoolCount = 0;	// Shared between threads

		public PoolTestForm()
		{
			InitializeComponent();

			int nWorkerThreads;
			int nIOThreads;
			int nMaxThreads;

			ThreadPool.GetAvailableThreads(out nWorkerThreads, out nIOThreads);
			nMaxThreads = Math.Min(100, nWorkerThreads);
			txtAvaliable.Text = String.Format("{0}", nMaxThreads);

			txtRunning.Text = "0";

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
					m_nPoolCount++;
				}
				else if (m_nPoolCount > 0)
				{
					m_nPoolCount--;
					if (m_nPoolCount == 0)
						m_bQuit = true;
				}
			}
		}

		void TimerCallbackMethod(Object objState, EventArgs evtArgs)
		{
			txtRunning.Text = String.Format("{0}", m_nPoolCount);

			// If we're quitting and Pool Count is zero, then kill the timer.
			if (m_bQuit && (m_nPoolCount <= 0))
			{
				Trace.WriteLine("Stopping timer");
				m_timerStatus.Stop();

				m_bQuit = false;
				m_bStarted = false;
				numDesired.Enabled = true;
				btnStart.Text = "&Start";
			}
		}

		// Called by the pool threads when the thread has completed.
		void ThreadFinish(Int32 nThreadID)
		{
			Trace.WriteLine(String.Format("Thread {0} has completed", nThreadID));
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

		void DoStart()
		{
			m_bQuit = false;

			btnStart.Text = "&Stop";
			numDesired.Enabled = false;

			FinishedDelegate finishedCallback = ThreadFinish;
			for (int nIx=0; nIx< numDesired.Value; nIx++)
			{
				Int32 nPeriod = m_Random.Next(5, 15);
				ThreadPool.QueueUserWorkItem(WorkItem, new Object[] { finishedCallback, nPeriod, ++m_nThreadID });

				Person personMySelf = new Person("Jeff");
				Action<Person> actPoolParam = new Action<Person>(WorkItemWParam);
				ThreadPool.QueueUserWorkItem(
					(Object obj) =>
					{
						WorkItemWParam((Person)obj);
					}, 
					personMySelf);
			}

			m_timerStatus.Start();
		}

		void DoStop()
		{
			m_bQuit = true;
		}

		void WorkItem(Object objState)
		{
			Object[] aParams = objState as Object[];
			FinishedDelegate finishedCallback = aParams[0] as FinishedDelegate;
			Int32 nPeriod = (Int32)aParams[1];
			Int32 nThreadID = (Int32)aParams[2];

			UpdatePoolCount(true);

			Trace.WriteLine(String.Format("Thread {0} starting, Period = {1} seconds", nThreadID, nPeriod));

			for (int nIx=0; nIx<nPeriod*10; nIx++)
			{
				Thread.Sleep(100);
				if (m_bQuit)
					break;
			}

			if (finishedCallback != null)
			{
				finishedCallback(nThreadID);
			}

			UpdatePoolCount(false);
		}

		void WorkItemWParam(Person p_perPerson)
		{
			Trace.WriteLine(String.Format("Name: {0}", p_perPerson.FName));
		}
	}
}
