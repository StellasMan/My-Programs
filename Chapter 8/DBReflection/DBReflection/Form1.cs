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

namespace DBReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void OnStartClick(object sender, EventArgs e)
		{
			Person tstPerson = new Person();

			if (tstPerson.GetPerson(1))
			{
				Trace.WriteLine(String.Format("Person with id of {0} - First Name: {1}", 1, tstPerson.m_FName));
			}
		}

		private void OnCustomClick(object sender, EventArgs e)
		{
			Assembly currentAssembly = Assembly.GetExecutingAssembly();
			Type[] aTypes = currentAssembly.GetExportedTypes();

			if ((aTypes != null) && (aTypes.Count() > 0))
			{
				foreach (Type tyItem in aTypes)
				{
					if (tyItem.IsClass)
					{
						Trace.WriteLine(String.Format("Properties for class {0}", tyItem.FullName));
						PropertyInfo[] aPInfo = tyItem.GetProperties();
						foreach(PropertyInfo propItem in aPInfo)
						{
							Trace.WriteLine(String.Format("  Property: {0};", propItem.Name));
						}

						Object[] aobjAttributes = tyItem.GetCustomAttributes(false);
						Trace.WriteLine(String.Format("Attributes for class {0}", tyItem.FullName));
						foreach (Object objItem in aobjAttributes)
						{
							System.Attribute sysAttrib = objItem as System.Attribute;
							Trace.WriteLine(String.Format("  Attribute: {0};", sysAttrib.GetType().Name));

							Trace.WriteLine(String.Format("  Properties for Attribute: {0};", sysAttrib.GetType().Name));
							PropertyInfo[] attribPropInfos = sysAttrib.GetType().GetProperties();
							foreach(PropertyInfo attribPropItem in attribPropInfos)
							{
								Trace.WriteLine(String.Format("    Property: {0};", attribPropItem.Name));
							}
						}
					}
				}
			}
		}
	}
}
