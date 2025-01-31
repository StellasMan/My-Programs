using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTest
{
	public partial class AsyncTestForm : Form
	{
		bool m_bRunning = false;
		int m_nTrials = 0;

		public AsyncTestForm()
		{
			InitializeComponent();
		}

		private void AsyncTestForm_Load(object sender, EventArgs e)
		{
			btnStart.Click += async (button, buttonArgs) =>
			{
				if (m_bRunning == true)
				{
					btnStart.Text = "&Start";
					m_bRunning = false;
					txtStatus.Text = String.Format("Test {0} complete", m_nTrials);
				}
				else
				{
					int nTrial = ++m_nTrials;
					txtStatus.Text = String.Format("Running test {0}", nTrial);
					btnStart.Text = "&Stop";
					m_bRunning = true;
					await DoAsyncTask();
				}
			};
		}

		private async Task DoAsyncTask()
		{
			int nCounter = 0;

			while (m_bRunning)
			{
				txtCounter.Text = String.Format("{0}", ++nCounter);
				await Task.Delay(50);
			}
		}
	}
}
