using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelTest
{
	public partial class ParallelForm : Form
	{
		public ParallelForm()
		{
			InitializeComponent();

			m_tmTimer.Interval = 200;
			m_tmTimer.Tick += new EventHandler(ProcessTimerTick);
			m_tmTimer.Enabled = false;
		}

		private void OnStartStop(object sender, EventArgs e)
		{
			if (!m_bStarted)
			{
				m_bStarted = true;
				DoStart();
			}
			else
			{
				DoStop();

			}
		}

		private void DoStart()
		{
			double dblResult = 0d;
			m_nQueued = (int)nudTasks.Value;
			m_nRunning = 0;
			m_nComplete = 0;
			btnStart.Text = "&Stop";
			m_bStarted = true;
			m_tmTimer.Enabled = true;
			rtxtStatus.Clear();

			txtQueued.Text = "0";
			txtRunning.Text = "0";
			txtComplete.Text = "0";

			Parallel.For
			(	
				0,
				(int)nudTasks.Value, 
				new Action<int>
					(
						(int nIx) =>
						{

							dblResult += DoIntensiveCalcs(nIx+1);
						}
					)
			);
		}

		private void DoStop()
		{
			Trace.WriteLine("Stop not enabled");
		}

		private void ProcessTimerTick(Object myObject, EventArgs myEventArgs)
		{
			int nQueued = 0;
			int nRunning = 0;
			int nComplete = 0;

			lock(m_objLock)
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

			if ((nQueued == 0) && (nRunning == 0))
			{
				while (m_qstrMessages.TryDequeue(out szStatus))
					rtxtStatus.Text += szStatus;

				btnStart.Text = "&Start";
				m_bStarted = false;
				m_tmTimer.Enabled = false;
			}
		}

		private double DoIntensiveCalcs(int nThreadID)
		{
			Trace.WriteLine(String.Format("Starting Task {0:D}", nThreadID));

			int nQueued = 0;
			int nRunning = 0;
			int nComplete = 0;

			lock (m_objLock)
			{
				nQueued = --m_nQueued;
				nRunning = ++m_nRunning;
			}

			m_qstrMessages.Enqueue(String.Format("Starting Task {0:D}\n", nThreadID));

			double dblResult = 0;

			Stopwatch stStopWatch = new Stopwatch();
			stStopWatch.Start();

			Random rand = new Random(nThreadID);

			double[] dblArrResults = new double[5000];
			for (int nIx = 0; nIx < 5000; nIx++)
			{
				try
				{
					double dblInterim = 0;
					int nMax = rand.Next(5000, 100000);
					for (int nIy = 1; nIy <= nMax; nIy++)
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

			Trace.WriteLine(String.Format("                      Task {0:D} required {1:D6} msecs to execute", nThreadID, stStopWatch.ElapsedMilliseconds));

			lock (m_objLock)
			{
				nRunning = --m_nRunning;
				nComplete = ++m_nComplete;
			}

			m_qstrMessages.Enqueue(String.Format("Task {0:D} completed in {1:D} msecs\n", nThreadID, stStopWatch.ElapsedMilliseconds));

			return dblResult;
		}

		private int m_nQueued = 0;
		private int m_nRunning = 0;
		private int m_nComplete = 0;

		private Object m_objLock = new Object();
		private bool m_bStarted = false;

		ConcurrentQueue<String> m_qstrMessages = new ConcurrentQueue<String>();

		Timer m_tmTimer = new Timer();
	}
}
