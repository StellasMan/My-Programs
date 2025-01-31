using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formatting
{
	public partial class FormattingForm : Form
	{
		uint m_uiStartingLine = 1;

		public FormattingForm()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			lvFmtDisplay.View = View.Details;
			lvFmtDisplay.CheckBoxes = false;
			lvFmtDisplay.GridLines = true;

			lvFmtDisplay.Columns.Add("Item", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 1", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 2", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 3", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 4", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 5", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 6", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 7", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Format 8", 100, HorizontalAlignment.Center);

			lvFmtDisplay.Columns.Add("Date Fmt 1", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 2", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 3", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 4", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 5", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 6", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 7", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 8", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 9", 100, HorizontalAlignment.Center);
			lvFmtDisplay.Columns.Add("Date Fmt 10", 100, HorizontalAlignment.Center);

			m_uiStartingLine = 1;

			DoBtnAdd();
		}

		private void OnBtnAdd(object sender, EventArgs e)
		{
			int nTest = 5;
			int nSquared = nTest.square();
			System.Diagnostics.Trace.WriteLine(String.Format("Value is {0}; Square is {1}\n", nTest, nSquared));

			DoBtnAdd();
		}

		private void DoBtnAdd()
		{
			DateTime timeNow = DateTime.Now;
			Random rand = new Random(timeNow.Second);

			for (int nIx=0; nIx<10; nIx++)
			{
				String szItem = String.Format("Item {0}", m_uiStartingLine);
				ListViewItem item = new ListViewItem(szItem);

				double dValue = rand.Next(1, 10000000)/100.0;

				item.SubItems.Add(String.Format("{0:C}", dValue));
				item.SubItems.Add(String.Format("{0:D}", (int)Math.Round(dValue)));
				item.SubItems.Add(String.Format("{0:E}", dValue));
				item.SubItems.Add(String.Format("{0:F}", dValue));
				item.SubItems.Add(String.Format("{0:G}", dValue));
				item.SubItems.Add(String.Format("{0:N}", dValue));
				item.SubItems.Add(String.Format("{0:P}", (dValue % 100)/100.0));
				item.SubItems.Add(String.Format("0x{0:X}", (int)Math.Round(dValue)));

				DateTime dtItem = timeNow.AddDays(m_uiStartingLine);

				item.SubItems.Add(String.Format("{0:d}", dtItem));
				item.SubItems.Add(String.Format("{0:D}", dtItem));
				item.SubItems.Add(String.Format("{0:f}", dtItem));
				item.SubItems.Add(String.Format("{0:F}", dtItem));
				item.SubItems.Add(String.Format("{0:g}", dtItem));
				item.SubItems.Add(String.Format("{0:G}", dtItem));
				item.SubItems.Add(String.Format("{0:M}", dtItem));
				item.SubItems.Add(String.Format("{0:t}", dtItem));
				item.SubItems.Add(String.Format("{0:T}", dtItem));
				item.SubItems.Add(String.Format("{0:Y}", dtItem));

				lvFmtDisplay.Items.Add(item);

				m_uiStartingLine++;
			}
		}
	}

	public static class ExtendedMethods
	{
		public static int square(this int num)
		{
			return num * num;
		}
	}
}
