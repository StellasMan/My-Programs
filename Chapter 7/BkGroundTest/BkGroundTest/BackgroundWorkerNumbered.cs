using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace BkGroundTest
{
	public class BackgroundWorkerNumbered : BackgroundWorker
	{
		public BackgroundWorkerNumbered(int nWorkerID)
		{
			m_nWorkerID = nWorkerID;
		}

		public int WorkerID
		{
			get { return m_nWorkerID; }
		}

		private readonly int m_nWorkerID = 0;
	}
}
