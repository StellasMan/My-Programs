using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchTest
{
	public partial class StopWatchForm : Form
	{
		Cursor[] arrCursors =
		{
				Cursors.AppStarting, Cursors.Arrow, Cursors.Cross,
				Cursors.Default, Cursors.Hand, Cursors.Help,
				Cursors.HSplit, Cursors.IBeam, Cursors.No,
				Cursors.NoMove2D, Cursors.NoMoveHoriz, Cursors.NoMoveVert,
				Cursors.PanEast, Cursors.PanNE, Cursors.PanNorth,
				Cursors.PanNW, Cursors.PanSE, Cursors.PanSouth,
				Cursors.PanSW, Cursors.PanWest, Cursors.SizeAll,
				Cursors.SizeNESW, Cursors.SizeNS, Cursors.SizeNWSE,
				Cursors.SizeWE, Cursors.UpArrow, Cursors.VSplit, Cursors.WaitCursor
		};

		int nCurCursor = 0;

		public StopWatchForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Thread thrdMain = new Thread
			(	() =>
				{
					Stopwatch sw = Stopwatch.StartNew();
					double dblResult1 = 0d;
					double dblResult2 = 0d;

					Thread thrd1 = new Thread((Object obj) => dblResult1 = ReadDataFromIO(obj));
					Thread thrd2 = new Thread((Object obj) => dblResult2 = DoCalc(obj));

					thrd1.Start(5000);
					thrd2.Start(2000);

					thrd1.Join();
					thrd2.Join();

					sw.Stop();

					double dblFinal = dblResult1 + dblResult2;
					Trace.WriteLine(String.Format("Result: {0:F2} required {1:F3} seconds", dblFinal, sw.Elapsed.TotalMilliseconds / 1000.0));

					Action actItem = new Action(() => 
						{
							txtTime.Text = String.Format("{0:F3}", sw.ElapsedMilliseconds / 1000.0);
							txtValue.Text = String.Format("{0:F2}", dblFinal);
							btnStart.Enabled = true;
							Cursor = Cursors.Default;
						}
					);

					if (InvokeRequired)
					{
						Invoke(actItem);
					}
					else
					{
						actItem();
					}
				}
			);

			btnStart.Enabled = false;
			txtTime.Clear();
			txtValue.Clear();
			Cursor = Cursors.WaitCursor;

			thrdMain.Start();
		}

		private double ReadDataFromIO(Object obj)
		{
			int nMSecs = (int)obj;
			System.Threading.Thread.Sleep(nMSecs);
			return 10d;
		}

		private double DoCalc(Object obj)
		{
			int nLimit = (int)obj;
			Stopwatch sw = Stopwatch.StartNew();
			double dblVal = 0;

			for (int nIx = 0; nIx < nLimit; nIx++)
			{
				for (int nIy = 1; nIy <= 1000000; nIy++)
					dblVal += Math.Sqrt(nIy);
			}

			sw.Stop();

			Trace.WriteLine(String.Format("Calculation took {0:F2} ms", sw.Elapsed.TotalMilliseconds));
			return dblVal;
		}

		private void OnCursor(object sender, EventArgs e)
		{
			Cursor = arrCursors[nCurCursor++];
			if (nCurCursor >= arrCursors.GetLength(0))
				nCurCursor = 0;
		}
	}
}
