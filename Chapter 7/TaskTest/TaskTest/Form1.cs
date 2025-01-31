using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTest
{
	public partial class TaskTestForm : Form
	{

		private bool m_bIsRunning = false;
		private bool m_bCancelPending = false;
		private Random rnd = new Random(DateTime.Now.Millisecond);
		private LinkedList<Task> m_lstTasks = new LinkedList<Task>();
		private Stopwatch m_stopWatch = new Stopwatch();
		private CancellationTokenSource m_cancelTknSrc;

		public TaskTestForm()
		{
			InitializeComponent();
			radTask.Checked = true;
			radFactory.Checked = false;
		}

		private void OnStartStop(Object sender, EventArgs e)
		{
			if (m_bIsRunning)
			{
				DoStop();
			}
			else
			{
				m_bIsRunning = true;
				btnStartStop.Text = "&Stop";
				lvStatus.Items.Clear();
				DoStart();
			}
		}

		private void DoStart()
		{
			lvStatus.Items.Clear();
			nudThreads.Enabled = false;
			m_lstTasks.Clear();
			m_stopWatch.Reset();
			m_stopWatch.Start();

			if (radFactory.Checked)
				DoFactoryStart();
			else if (radTask.Checked)
				DoTaskStart();
			else
				DoUIThreadStart();
		}

		private void DoFactoryStart()
		{
			Action<Object> taskActionSimple = (Object obj) =>
			{
				Object[] objItems = obj as Object[];
				Int32 nRange = (int)objItems[0];
				Int32 nDelay = (Int32)objItems[1];
				CancellationToken tknCancel = (CancellationToken)objItems[2];

				Thread thisThread = Thread.CurrentThread;
				Trace.WriteLine(String.Format("Starting thread {0}", thisThread.ManagedThreadId));

				foreach (int count in Enumerable.Range(0, nRange))
				{
					Thread.Sleep(nDelay);
					if (tknCancel.IsCancellationRequested)
						break;
				}

				Trace.WriteLine(String.Format("Thread {0} complete", thisThread.ManagedThreadId));
			};

			m_cancelTknSrc = new CancellationTokenSource();
			Random rnd = new Random(DateTime.Now.Millisecond);
			foreach (int nCounter in Enumerable.Range(0, (int)nudThreads.Value))
			{
				int nRange = rnd.Next(5, 50);
				int nDelay = rnd.Next(100, 500);
				Task taskItem = Task.Factory.StartNew(taskActionSimple, new Object[] { nRange, nDelay, m_cancelTknSrc.Token });
				m_lstTasks.AddLast(taskItem);
			}

			Task.Run(new Action(TasksWait));
		}

		private void DoTaskStart()
		{
			Action actionTask = () =>
			{
				Thread thisThread = Thread.CurrentThread;
				Trace.WriteLine(String.Format("Starting thread {0}", thisThread.ManagedThreadId));
				foreach (int nCount in Enumerable.Range(0, 100))
				{
					Thread.Sleep(100);
					if (m_bCancelPending)
						break;
				}

				Trace.WriteLine(String.Format("Thread {0} complete", thisThread.ManagedThreadId));
			};

			// Create an anonymous method referenced by Action delegate 'tskCompleted'
			// which is called when all tasks are complete and is run in the context
			// of the UI thread.
			Action tasksCompleted = () =>
			{
				nudThreads.Enabled = true;
				btnStartStop.Text = "&Start";
			};

			foreach (int nCounter in Enumerable.Range(0, (int)nudThreads.Value))
			{
				m_lstTasks.AddLast(Task.Run(actionTask));
			}

			Task.Run(new Action(TasksWait));
		}

		// This method runs the task on the current (UI) thread
		private void DoUIThreadStart()
		{
			Task.Factory.StartNew
			(
				UpdateUIThread,
				CancellationToken.None,
				TaskCreationOptions.None,
				TaskScheduler.FromCurrentSynchronizationContext()
			);
		}

		private void UpdateUIThread()
		{
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			foreach (int nCount in Enumerable.Range(0, 100))
			{
				Thread.Sleep(100);
			}

			stopWatch.Stop();
			Trace.WriteLine(String.Format("Elapsed Time: {0} milliseconds", stopWatch.ElapsedMilliseconds));
		}

		private void DoStop()
		{
			if (!m_bCancelPending)
			{
				m_bCancelPending = true;
				if (radFactory.Checked)
					DoFactoryStop();
				else
					DoTaskStop();
			}
		}

		private void DoTaskStop()
		{
		}

		private void DoFactoryStop()
		{
			m_cancelTknSrc.Cancel();
		}

		private void TasksWait()
		{
			// Create an anonymous method referenced by Action delegate 'tskCompleted'
			// which is called when all tasks are complete and is run in the context
			// of the UI thread.
			Action tasksCompleted = () =>
			{
				nudThreads.Enabled = true;
				btnStartStop.Text = "&Start";
			};

			Task.WaitAll(m_lstTasks.ToArray<Task>());

			m_stopWatch.Stop();

			m_bIsRunning = false;
			m_bCancelPending = false;
			nudThreads.Invoke(tasksCompleted);

			Trace.WriteLine(String.Format("Elapsed time = {0} ms", m_stopWatch.ElapsedMilliseconds));
		}
	}
}
