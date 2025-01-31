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

namespace TaskTest2
{
	public partial class TaskTestForm : Form
	{
		public TaskTestForm()
		{
			InitializeComponent();
			rtxtStatus.WordWrap = true;

			txtWaiting.Text = "0";
			txtRunning.Text = "0";
			txtComplete.Text = "0";

			nudTasks.Value = 100;
		}

		private void OnStart(object sender, EventArgs e)
		{
			if (!m_bStarted)
			{
				if (m_tknCancelSrc != null)
					m_tknCancelSrc.Dispose();

				m_tknCancelSrc = new CancellationTokenSource();
				StartTasks();
			}
			else
			{
				m_tknCancelSrc.Cancel();
			}
		}

		private void StartTasks()
		{
			int nTasks = (int)nudTasks.Value;
			m_nTaskID = 0;
			rtxtStatus.Clear();
			m_nWaiting = nTasks;
			m_nRunning = 0;
			m_nComplete = 0;

			txtWaiting.Text = "0";
			txtRunning.Text = "0";
			txtComplete.Text = "0";

			for (int nIx=0; nIx<nTasks; nIx++)
			{
				// Anonymous method.
				// This method is NOT run immediately when 'Task.Run' is called below.
				// Rather, it is put in the threadpool to await execution.
				Action actNow = new Action
				(
					() =>
					{
						int nTaskID = 0;
						lock (m_objLock)
						{
							nTaskID = ++m_nTaskID;
						}

						double dResult = DoIntensiveCalcs();
					}
				);

				Task tskItem = Task.Run(actNow, m_tknCancelSrc.Token);

				m_llstTasks.AddLast(tskItem);
			}

			m_bStarted = true;
			btnStart.Text = "&Stop";

			// Anonymous method which waits for all the threads to finish
			// and then sets the Start button text.
			ThreadStart thrdStart = new ThreadStart
			(() =>
				{
					Trace.WriteLine("Starting wait...");
					Task tskAllDone = Task.WhenAll(m_llstTasks);
					try
					{
						tskAllDone.Wait(30000, m_tknCancelSrc.Token);
					}
					catch(Exception ex)
					{
						Trace.WriteLine(String.Format("Exception occurred while waiting for task completion. \n{0}", ex.Message));
					}

					foreach (Task tskItem in m_llstTasks)
					{
						TaskStatus tskStatus = tskItem.Status;
						Trace.WriteLine(String.Format("Task Status for task {0} = {1}", tskItem.Id, tskStatus.ToString()));

						if (tskStatus == TaskStatus.Canceled)
						{
							int nWaiting = 0;
							lock(m_objLock)
							{
								nWaiting = --m_nWaiting;
							}

							Invoke
							(	new Action
								(() =>
									{
										txtWaiting.Text = String.Format("{0}", nWaiting);
									}
								)
							);
						}
					}

					Action actDone = new Action
					(
						() =>
						{
							m_bStarted = false;
							btnStart.Text = "&Start";
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
			);

			Thread thrdCheck = new Thread(thrdStart);
			thrdCheck.Priority = ThreadPriority.AboveNormal;
			thrdCheck.IsBackground = false;

			thrdCheck.Start();
		}

		private double DoIntensiveCalcs()
		{
			int nThreadID = Thread.CurrentThread.ManagedThreadId;
			Trace.WriteLine(String.Format("Starting Task {0:D}", nThreadID));

			lock(m_objLock)
			{
				m_nWaiting--;
				m_nRunning++;
				Invoke
				(new Action
					(() =>
						{
							rtxtStatus.Text += String.Format("Starting Task {0:D}\n", nThreadID);
							txtWaiting.Text = String.Format("{0}", m_nWaiting);
							txtRunning.Text = String.Format("{0}", m_nRunning);
						}
					)
				);
			}

			double dblResult = 0;

			Stopwatch stStopWatch = new Stopwatch();
			stStopWatch.Start();

			Random rand = new Random(nThreadID);

			double[] dblArrResults = new double[5000];
			for (int nIx=0; nIx<5000; nIx++)
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

				catch(Exception ex)
				{
					Trace.WriteLine(String.Format("Exception: {0}", ex.Message));
				}
			}

			dblResult = dblArrResults.Average();
			stStopWatch.Stop();

			Trace.WriteLine(String.Format("                      Task {0:D} required {1:D6} msecs to execute", nThreadID, stStopWatch.ElapsedMilliseconds));

			lock (m_objLock)
			{
				m_nRunning--;
				m_nComplete++;
				Invoke
				(new Action
					(() =>
						{
							txtRunning.Text = String.Format("{0}", m_nRunning);
							txtComplete.Text = String.Format("{0}", m_nComplete);
						}
					)
				);
			}

			return dblResult;
		}

		private int m_nWaiting = 0;
		private int m_nRunning = 0;
		private int m_nComplete = 0;

		private Object					m_objLock = new Object();
		private int						m_nTaskID = 0;
		private LinkedList<Task>		m_llstTasks = new LinkedList<Task>();
		private CancellationTokenSource m_tknCancelSrc = null;
		private bool					m_bStarted = false;
	}
}
