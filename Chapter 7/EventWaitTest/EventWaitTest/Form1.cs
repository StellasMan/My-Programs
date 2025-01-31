using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWaitTest
{
	public partial class EventWaitTestForm : Form
	{
		public EventWaitTestForm()
		{
			InitializeComponent();
			Task.Run
			(
				() =>
				{
					while (true)
					{
						m_autoQueueEvent.WaitOne(5000);
						ShowStatus();
					}
				}
			);
		}

		private void OnStart(object sender, EventArgs e)
		{
			int nThreads = (int)nudThreads.Value;
			m_nTaskCount = nThreads;

			// Initially in 'blocked' state
			m_autoEvent.Reset();
			m_manualEvent.Reset();

			txtThreads.Text = String.Format("{0}", m_nTaskCount);

			for (int nIx=0; nIx<nThreads; nIx++)
			{
				Task tskTest = new Task
				(
					() =>
					{
						WaitHandle[] aHandles = new WaitHandle[] { m_autoEvent, m_manualEvent };
						WaitHandle.WaitAny(aHandles);

						int nTaskCount = 0;
						lock(m_objLock)
						{
							nTaskCount = --m_nTaskCount;
						}

						Invoke
						(new Action<String>
							(
								(String s) =>
								{
									txtThreads.Text = String.Format("{0}", s);
								}
							),
							nTaskCount.ToString()
						);
					}
				);

				tskTest.Start();
			}
		}

		private void OnRelease(object sender, EventArgs e)
		{
			m_autoEvent.Set();	// Allow only 1 thread through
		}

		private void OnReleaseAll(object sender, EventArgs e)
		{
			m_manualEvent.Set();
		}

		Object m_objLock = new Object();
		int m_nTaskCount = 0;
		AutoResetEvent m_autoEvent = new AutoResetEvent(false);			// Non-signalled initially
		ManualResetEvent m_manualEvent = new ManualResetEvent(false);   // Manual reset, non-signalled

		//**********************************************************************************************************
		// Run CountdownEvent test
		//**********************************************************************************************************
		private void OnCDStart(object sender, EventArgs e)
		{
			m_nCDThreads = (int)nudCDThreads.Value;
			Random rand = new Random(DateTime.Now.Millisecond);
			btnCDStart.Text = "Wai&t";

			if (m_cdeCDEvent != null)
				m_cdeCDEvent.Dispose();

			m_cdeCDEvent = new CountdownEvent(m_nCDThreads);

			Action actThread = new Action(
				() =>
				{
					int nValue = rand.Next(100, 500);
					ReadData(nValue);

					lock(objCDLock)
					{
						m_nCDThreads--;
					}

					m_cdeCDEvent.Signal();

					UpdateCDEvent();
				}
			);

			for (int nIx=0; nIx< m_nCDThreads; nIx++)
			{
				Task.Run(actThread);
			}

			BackgroundWorker bkWorker = new BackgroundWorker();
			bkWorker.DoWork += BkWorkerDoWork;
			bkWorker.RunWorkerCompleted += BkWorkCompleted;

			bkWorker.RunWorkerAsync(m_cdeCDEvent);
		}

		private void BkWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			CountdownEvent cdEvent = e.Argument as CountdownEvent;

			// Don't wait more than 30 seconds
			for (int nIx=0; !cdEvent.IsSet && (nIx < 30); nIx++)
			{
				cdEvent.Wait(new TimeSpan(0, 0, 1));    // Wait 1 second, no more
				Trace.WriteLine(String.Format("Wait time {0} seconds, Event is {1}set", nIx + 1, cdEvent.IsSet ? "" : "NOT "));
			}

		}

		private void UpdateCDEvent()
		{
			Action actUpdate = new Action
			(
				() =>
				{
					txtCDThreads.Text = String.Format("{0}", m_nCDThreads);
					txtCDCount.Text = String.Format("{0}", m_cdeCDEvent.CurrentCount);
				}
			);

			if (InvokeRequired)
			{
				Invoke(actUpdate);
			}
			else
			{
				actUpdate();
			}
		}

		private void BkWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Action actDone = new Action
			(
				() =>
				{
					UpdateCDEvent();
					btnCDStart.Text = "S&tart";
					Console.Beep(1000, 500);
				}
			);

			if (InvokeRequired)
			{
				Invoke(actDone);
			}
			else
			{
				actDone();
			}
		}

		double ReadData(int nLimit, int nThreadID = -1)
		{
			Stopwatch sw = Stopwatch.StartNew();
			double dblVal = 0;

			for (int nIx = 0; nIx < nLimit; nIx++)
			{
				for (int nIy = 1; nIy <= 1000000; nIy++)
					dblVal += Math.Sqrt(nIy);
			}

			sw.Stop();

			String szMsg = (nThreadID == -1) ? String.Empty : String.Format("Thread {0} has finished reading data; ", nThreadID);
			szMsg += String.Format("Calculation took {0:F2} ms", sw.Elapsed.TotalMilliseconds);
			Trace.WriteLine(szMsg);

			return dblVal;
		}

		Object objCDLock = new object();
		int m_nCDThreads = 0;
		CountdownEvent m_cdeCDEvent = null;

		//**********************************************************************************************************
		// Barrier testing
		//**********************************************************************************************************

		void UpdateStatus(String szMsg)
		{
			m_msgQueue.Enqueue(szMsg);
			m_autoQueueEvent.Set();
		}

		void ShowStatus()
		{
			String szMsg;
			while (m_msgQueue.TryDequeue(out szMsg))
			{
				if (InvokeRequired)
				{
					Invoke
					(	new Action
						(
							() =>
							{
								rtxtStatus.Text += szMsg;
							}
						)
					);
				}
				else
				{
					rtxtStatus.Text += szMsg;
				}
			}
		}

		private void OnBarrierStart(object sender, EventArgs e)
		{
			int partCount = (int)nudParticipants.Value;
			Task[] tasks = new Task[partCount];
			m_barBarrier = new Barrier
			(	0,
				(Barrier b) =>
				 {
					 String szMsg = String.Format(String.Format("Finalize barrier called. Phase {0} Complete\n", b.CurrentPhaseNumber+1));
					 UpdateStatus(szMsg);
				 }
			);

			for (int nIx = 0; nIx < partCount; nIx++)
			{
				m_barBarrier.AddParticipant();

				int nTaskNo = nIx;
				Random rand = new Random(DateTime.Now.Millisecond);
				tasks[nTaskNo] = Task.Factory.StartNew(() =>
				{
					String szMsg;
					int phaseCount = (int)nudPhases.Value;
					for (int nPhase = 0; nPhase < phaseCount; nPhase++)
					{
						int nFactor = rand.Next(500, 1000);
						szMsg = String.Format("Starting task {0} Phase {1}\n", nTaskNo + 1, nPhase + 1);
						UpdateStatus(szMsg);
						Trace.WriteLine(szMsg);
						ReadData(nFactor, nTaskNo);
						m_barBarrier.SignalAndWait();
						szMsg = String.Format("Task {0} Phase {1} complete\n", nTaskNo + 1, nPhase + 1);
						Trace.WriteLine(szMsg);
						Thread.Sleep(100);
					}
				});
			}

			//Trace.WriteLine("Backup completed");
		}

		AutoResetEvent m_autoQueueEvent = new AutoResetEvent(false);	// Non-signalled initially

		ConcurrentQueue<String> m_msgQueue = new ConcurrentQueue<String>();
		Barrier m_barBarrier = null;
	}
}
