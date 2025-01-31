using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionTest
{
	public partial class ExtTestForm : Form
	{
		public ExtTestForm()
		{
			InitializeComponent();
		}

		private void OnTest(object sender, EventArgs e)
		{
			int nBase = 3;
			int nPOW = nBase.Cube();
			nPOW = new Int32(3);
		}
	}
}
