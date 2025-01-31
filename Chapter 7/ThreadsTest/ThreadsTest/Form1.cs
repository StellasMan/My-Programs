using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace ThreadsTest
{
	public partial class ThreadsTestForm : Form
	{
		public ThreadsTestForm()
		{
			InitializeComponent();

			m_aTextBoxes[0] = txtCounter1;
			m_aTextBoxes[1] = txtCounter2;
			m_aTextBoxes[2] = txtCounter3;
			m_aTextBoxes[3] = txtCounter4;
			m_aTextBoxes[4] = txtCounter5;
			m_aTextBoxes[5] = txtCounter6;
			m_aTextBoxes[6] = txtCounter7;
			m_aTextBoxes[7] = txtCounter8;

			m_timerStatus = new System.Threading.Timer(TimerStatus);
		}

		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (m_lstThreads.Count > 0)
			{
				// Queue exit, but don't stop yet
				m_bStop = true;
				m_bQuit = true;
				e.Cancel = true;
			}
		}
		private void OnStartStop(object sender, EventArgs e)
		{
			if (m_bRunning)
			{
				m_bStop = true;
			}
			else
			{
				StartThreads();
				btnStartStop.Text = "&Stop";
				m_timerStatus.Change(0, 250);
			}
		}

		private void StartThreads()
		{
			Random rnd = new Random(10);

			Int32 nThreads = (Int32)numThreadCount.Value;

			foreach (TextBox txtItem in m_aTextBoxes)
				txtItem.Clear();

			m_bRunning = true;
			m_bStop = false;
			m_lstThreads.Clear();

			for (int nIx = 0; nIx < nThreads; nIx++)
			{
				int nRange = rnd.Next(50, 100);
				int nDelay = rnd.Next(50, 100);

				ParameterizedThreadStart thrdStart = new ParameterizedThreadStart(RunThread);
				Thread thrdItem = new Thread(thrdStart);
				thrdItem.Name = String.Format("Thread {0}", nIx + 1);
				m_lstThreads.AddLast(thrdItem);
				thrdItem.Start(new Object[] { m_aTextBoxes[nIx], nRange, nDelay } );
			}
		}

		private void TimerStatus(Object objState)
		{
			bool bStillRunning = false;
			foreach(Thread thrdItem in m_lstThreads)
			{
				if (thrdItem.IsAlive)
				{
					bStillRunning = true;
					break;
				}
			}

			if (!bStillRunning)
			{
				m_bRunning = false;
				Invoke(actionSetText, new Object[] { btnStartStop, "&Start" }); // btnStartStop.Text = "&Start";
				m_lstThreads.Clear();
				m_timerStatus.Change(Timeout.Infinite, Timeout.Infinite);

				if (m_bQuit)
					Application.Exit();
			}
		}

		private void RunThread(Object objItem)
		{
			Object[] objParams = objItem as Object[];
			TextBox txtItem = objParams[0] as TextBox;
			int nRange = (Int32)objParams[1];
			int nDelay = (Int32)objParams[2];

			Thread thrdCounter = Thread.CurrentThread;
			Trace.WriteLine(String.Format("Starting thread '{0}': Range: {1}, Delay:{2}", thrdCounter.Name, nRange, nDelay));

			if (txtItem != null)
			{
				Invoke(actionClear, new Object[] { txtItem } );

				int nMax = 1000000 * nDelay;
				for (int nIx=0; !m_bStop && (nIx<nRange); nIx++)
				{
					Int16 nCount = Int16.MaxValue;
					for (int nIy=0; !m_bStop && (nIy < nMax); nIy++)
						while (!m_bStop && (nCount > 0)) nCount--;

					String sText = String.Format("{0}", nIx + 1);
					Invoke(actionSetText, new Object[] { txtItem, sText });
				}
			}

			Trace.WriteLine(String.Format("Exiting thread '{0}'", thrdCounter.Name));
		}

		private Action<TextBox> actionClear = (TextBox txtBox) => { txtBox.Clear(); };
		private Action<Control, String> actionSetText = (Control ctrlItem, String sValue) => { ctrlItem.Text = sValue; };

		private System.Threading.Timer m_timerStatus;
		private LinkedList<Thread> m_lstThreads = new LinkedList<Thread>();
		private TextBox[] m_aTextBoxes = new TextBox[8];
		private bool m_bStop = false;
		private bool m_bRunning = false;
		private bool m_bQuit = false;       // TRUE when we should exit after threads are stopped
	}
}
