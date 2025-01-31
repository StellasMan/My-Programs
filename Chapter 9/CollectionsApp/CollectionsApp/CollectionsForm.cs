using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsApp
{
	public partial class CollectionForm : Form
	{
		public CollectionForm()
		{
			InitializeComponent();
		}

		private void AListThread(Object objItem)
		{
			Collections collCollections = objItem as Collections;
			if (collCollections != null)
			{
				collCollections.ExerciseArrayList();
			}
		}

		private void OnStart(object sender, EventArgs e)
		{
			Thread thrdTest = new Thread(ThreadTest);
			thrdTest.Start();
		}

		private void ThreadTest()
		{
			Thread thrdAList = new Thread(AListThread);
			thrdAList.Name = "ArrayList Thread";
			thrdAList.Priority = ThreadPriority.AboveNormal;
			thrdAList.Start(m_collCollections);

			int nWorkerThreads;
			int nIOPortThreads;
			ThreadPool.GetAvailableThreads(out nWorkerThreads, out nIOPortThreads);
			nWorkerThreads = 5;	// Math.Min(64, nWorkerThreads);

			EventWaitHandle[] evHandles = new EventWaitHandle[nWorkerThreads];
			for (int nIx = 0; nIx < nWorkerThreads; nIx++)
			{
				evHandles[nIx] = new EventWaitHandle(false, EventResetMode.ManualReset);
				Random rand = new Random(DateTime.Now.Millisecond);
				Object[] objItems = new Object[] { rand, evHandles[nIx] };
				WaitCallback wCallback = new WaitCallback((obj) => { m_collCollections.ExerciseSortedList(objItems); });
				ThreadPool.QueueUserWorkItem(wCallback, objItems);
			}

			BackgroundWorker bkWorker = new BackgroundWorker();
			bkWorker.DoWork += 
			m_collCollections.ExerciseHashTable();
			m_collCollections.ExerciseCustom();

			EventWaitHandle.WaitAll(evHandles);
			foreach (var item in m_collCollections.m_srtList.Keys)
			{
				Trace.WriteLine(String.Format("Key: {0,5}; Value: {1}", item, m_collCollections.m_srtList[item]));
			}
		}

		private void OnDBTest(object sender, EventArgs e)
		{
			DBSample dbSample = new DBSample();
			dbSample.TestConnection();
		}

		Collections m_collCollections = new Collections();
	}
}
