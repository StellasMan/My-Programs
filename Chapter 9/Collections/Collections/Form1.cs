using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
	public partial class SortedArrayForm : Form
	{
		ArrayList arrStudents = new ArrayList();

		private void InitializeStudents()
		{
			Student stStudent = new Student("Armstrong", "Stella", new Address("2210 Garrett Drive", "", "Killeen", "TX", "76543"));
			arrStudents.Add(stStudent);

			stStudent = new Student("Armstrong", "Jeff", new Address("4204 Shawn Drive Apt B", "", "Killeen", "TX", "76542"));
			arrStudents.Add(stStudent);

			stStudent = new Student("Armstrong", "Jeff", new Address("2210 Garrett Drive", "", "Killeen", "TX", "76543"));
			arrStudents.Add(stStudent);
		}

		public SortedArrayForm()
		{
			InitializeComponent();
		}

		private void SortedArrayForm_Load(object sender, EventArgs e)
		{
			InitializeStudents();
		}

		private void OnSort(object sender, EventArgs e)
		{
			Trace.WriteLine("*** Before sort ***");
			foreach (Student stItem in arrStudents) 
			{
				Trace.WriteLine(stItem.ToString());
			}

			arrStudents.Sort();

			Trace.WriteLine("*** After sort ***");
			foreach (Student stItem in arrStudents) 
			{
				Trace.WriteLine(stItem.ToString());
			}
		}
	}
}
