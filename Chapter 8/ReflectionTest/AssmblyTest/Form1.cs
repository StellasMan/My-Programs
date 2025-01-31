using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssmblyTest
{
	public partial class AssmblyTestForm : Form
	{
		public AssmblyTestForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Assembly formAssembly = Assembly.GetExecutingAssembly();
			AssemblyName[] asmNames = formAssembly.GetReferencedAssemblies();

			Trace.WriteLine(String.Format("{0,20} {1,50} {2,20} {3,20} {4,20} {5,20} {6,20} {7,20} {8,20} {9,20} {10,20} {11,20} {12,20} {13,20} {14,20} {15,20} {16,20}",
					"Name",
					"Version",
					"Assembly",
					"AssemblyQualifiedName",
					"BaseType",
					"FullName",
					"IsAbstract",
					"IsArray",
					"IsClass",
					"IsEnum",
					"IsInterface",
					"IsNotPublic",
					"IsPublic",
					"IsSerializable",
					"IsValueType",
					"Name",
					"Namespace"));

			foreach(AssemblyName item in asmNames)
			{
				int nLen = Math.Min(50, item.Version.ToString().Length);
				Trace.Write(String.Format("{0,20} {1,50}", item.Name, item.Version.ToString().Trim().Substring(0, nLen)));

				Type itemType = item.GetType();
				Trace.Write(String.Format(" {0,20}", itemType.Assembly.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.AssemblyQualifiedName.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.BaseType.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.FullName.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsAbstract.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsArray.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsClass.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsEnum.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsInterface.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsNotPublic.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsPublic.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsSerializable.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.IsValueType.ToString().Substring(0, 20)));
				Trace.Write(String.Format(" {0,20}", itemType.Name.ToString().Substring(0, 20)));
				Trace.WriteLine(String.Format("{0,20}", itemType.Namespace.ToString().Substring(0, 20)));
			}
		}
	}
}
