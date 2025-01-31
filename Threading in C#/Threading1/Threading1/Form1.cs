using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Threads
{
    public partial class ThreadingForm : Form
    {
		const long TICKS_PER_SECOND = 10 * 1000 * 1000;

		Object objThreadSync = new object();
        private bool m_bClosing = false;

        private System.Timers.Timer m_tmTimer;
        private int m_nActiveThreads = 0;
        private int m_nQueuedThreads = 0;
        private LinkedList<Thread> m_thrdForeGround = new LinkedList<Thread>();
        private LinkedList<Thread> m_thrdBackGround = new LinkedList<Thread>();
        private AutoResetEvent m_autoResetEvent = new AutoResetEvent(false);
        public ThreadingForm()
        {
            InitializeComponent();
            FormClosing += ThreadingFormClosing;

            int nMinWorkers, nMinPorters;
            ThreadPool.GetMinThreads(out nMinWorkers, out nMinPorters);
            bool bSetOK = ThreadPool.SetMaxThreads(nMinWorkers*4, nMinPorters*4);
        }

        private void ThreadingFormClosing(object sender, FormClosingEventArgs e)
        {
            lock(objThreadSync)
            {
                m_bClosing = true;
            }
        }

        public void DisplayCount()
        {
            int nCount = 0;
            foreach (Thread thrd in m_thrdForeGround)
                if (thrd.IsAlive) nCount++;
            txtForeGround.Text = String.Format("{0}", nCount);

            nCount = 0;
            foreach (Thread thrd in m_thrdBackGround)
                if (thrd.IsAlive) nCount++;
            txtBkGround.Text = String.Format("{0}", nCount);
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            m_tmTimer = new System.Timers.Timer(250);

            // Hook up the Elapsed event for the timer. 
            m_tmTimer.Elapsed += OnTimedEvent;
            m_tmTimer.AutoReset = true;
            m_tmTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            lock (objThreadSync)
            {
                if (!m_bClosing)
                    this.Invoke(new Action(DisplayCount));
            }
        }

        private void OnStart(object sender, EventArgs e)
        {
            Random rnd = new Random();

            txtForeGround.Text = "?";
            txtBkGround.Text = "?";

            SetTimer();
            for (int nIx=0; nIx<10; nIx++)
            {
                int nLoops = rnd.Next(10, 100);
                Thread thrd1 = new Thread(FirstThread);
                thrd1.Name = String.Format("Thread{0}", nIx + 1);
                thrd1.Priority = ThreadPriority.Lowest;
                m_thrdForeGround.AddLast(thrd1);

                txtStatus.Text = String.Format("Starting foreground thread '{0}'", thrd1.Name);

                thrd1.Start(nLoops);
                Thread.Sleep(500);
            }

            for (int nIx=0; nIx<5; nIx++)
            {
                int nLoops = rnd.Next(100, 300);
                Thread thrd2 = new Thread(() => SecondThread(nIx, nLoops));
                thrd2.Name = String.Format("Thread2[{0}]", nIx + 1);
                thrd2.Priority = ThreadPriority.Highest;

                txtStatus.Text = String.Format("Starting background thread '{0}'", thrd2.Name);

                thrd2.IsBackground = true;
                m_thrdBackGround.AddLast(thrd2);

                thrd2.Start();
                Thread.Sleep(500);
            }
        }

        void FirstThread(Object objCount)
        {
            int nLoops = (int)objCount;
            String sThreadName = Thread.CurrentThread.Name;
            Console.WriteLine(String.Format("**** Starting loop for thread {0}; ({1} loops) ****", sThreadName, nLoops));

            for (int nIx = 0; nIx < nLoops; nIx++)
            {
                Console.WriteLine(String.Format("This is line {0} of thread {1}", nIx + 1, sThreadName));
                Thread.Sleep(100);
            }

            Console.WriteLine(String.Format("**** Loop for thread {0} Complete ****", sThreadName));
        }

        void SecondThread(int nThreadId, int nLoopCount)
        {
            Console.WriteLine(String.Format("**** Starting 2nd Thread loop for thread {0}; ({1} loops) ****", nThreadId, nLoopCount));

            for (int nIx = 0; nIx < nLoopCount; nIx++)
            {
                Console.WriteLine(String.Format("This is line {0} of 2nd thread {1}", nIx + 1, nThreadId));
                Thread.Sleep(100);
            }

            Console.WriteLine(String.Format("**** Loop for thread {0} Complete ****", nThreadId));
        }

        private void OnJoinAndExit(object sender, EventArgs e)
        {
            JoinThreads();
        }

        private void JoinThreads()
        {
            try
            {
                foreach (Thread thrd in m_thrdForeGround)
                {
                    if (thrd.IsAlive)
                    {
                        txtStatus.Text = String.Format("Waiting on thread {0}", thrd.Name);
                        thrd.Join(TimeSpan.FromSeconds(5));
                        if (thrd.IsAlive)
                        {
                            if (txtStatus.IsHandleCreated)
                                txtStatus.Text = String.Format("Aborting thread {0}", thrd.Name);

                            thrd.Abort();
                        }
                    }
                }

                foreach (Thread thrd in m_thrdBackGround)
                {
                    if (thrd.IsAlive)
                    {
                        txtStatus.Text = String.Format("Waiting on thread {0}", thrd.Name);
                        thrd.Join(TimeSpan.FromSeconds(5));
                        if (thrd.IsAlive)
                        {
                            if (txtStatus.IsHandleCreated)
                                txtStatus.Text = String.Format("Aborting thread {0}", thrd.Name);

                            thrd.Abort();
                        }
                    }
                }
            }
            catch(System.Threading.ThreadAbortException ex)
            {
                System.Diagnostics.Trace.WriteLine(String.Format("{0}", ex.Message));
            }
        }

        // *************************************************************************
        // * Thread Pool sample code
        // *************************************************************************
        private void OnStartThreadPool(object sender, EventArgs e)
        {
            Thread thrdPoolStarter = new Thread
                (() =>
                {
                    int nWorkers = 0;
                    int nPorters = 0;
                    ThreadPool.GetMaxThreads(out nWorkers, out nPorters);

                    for (int nIx = 0; nIx < 4 * nWorkers; nIx++)
                    {
                        int nState = 5;
                        Interlocked.Increment(ref m_nQueuedThreads);
                        ThreadPool.QueueUserWorkItem(ThreadPoolMethod, (Object)nState);
                    }
                }
                );

            ThreadPool.RegisterWaitForSingleObject(m_autoResetEvent, PooledQueueCallback, null, TimeSpan.FromHours(1), false);
            thrdPoolStarter.Start();
            Thread.Sleep(3000);

            ShowStatus();
        }

        private void ThreadPoolMethod(Object objItem)
        {
            int nSecondsToRun = (int)objItem;
            Interlocked.Increment(ref m_nActiveThreads);

            m_autoResetEvent.Set(); // Triggers call to callback method 'PooledQueueCallback'

            // Busy loop for 'nSecondsToRun' seconds
            DateTime dtStart = DateTime.Now;
            while (!m_bClosing)
            {
                long lTicks = (DateTime.Now.Ticks - dtStart.Ticks);
				Math.Sqrt(lTicks / Math.PI);	// Occupies floating point processor
                if (lTicks >= (nSecondsToRun * TICKS_PER_SECOND))   // 10 million ticks per second
                    break;
            }

            // Thread.Sleep(nSecondsToRun * 1000);

            Interlocked.Decrement(ref m_nActiveThreads);
            Interlocked.Decrement(ref m_nQueuedThreads);

            m_autoResetEvent.Set(); // Triggers call to callback method 'PooledQueueCallback'
        }

        private void PooledQueueCallback(object state, bool timedOut)
        {
            lock (objThreadSync)
            {
                if (!m_bClosing)
                    this.Invoke(new Action(ShowStatus));
            }
        }

        private void OnTimedPoolEvent(Object source, ElapsedEventArgs e)
        {
            lock (objThreadSync)
            {
                if (!m_bClosing)
                    this.Invoke(new Action(ShowStatus));
            }
        }

        private void OnStatus(object sender, EventArgs e)
        {
            ShowStatus();
        }

        private void ShowStatus()
        {
            int nWorkers, nPorters;
            int nWorkersMax, nPortersMax;

            ThreadPool.GetMaxThreads(out nWorkersMax, out nPortersMax);
            ThreadPool.GetAvailableThreads(out nWorkers, out nPorters);
            txtPooledAvail.Text = String.Format("{0}", nWorkers);
            txtPooledActive.Text = String.Format("{0}", m_nActiveThreads);
            txtPooledWaiting.Text = String.Format("{0}", m_nQueuedThreads - m_nActiveThreads);
        }
    }
}
