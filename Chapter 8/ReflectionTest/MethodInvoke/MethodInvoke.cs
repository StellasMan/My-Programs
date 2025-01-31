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

namespace MethodInvoke
{
	public partial class MethodInvokeForm : Form
	{
		public MethodInvokeForm()
		{
			InitializeComponent();
		}

		private void OnStart(object sender, EventArgs e)
		{
			Assembly asmAssembly = Assembly.GetExecutingAssembly();

			Type[] asmTypes = asmAssembly.GetTypes();
			foreach (Type typItem in asmTypes)
			{
				Trace.WriteLine(String.Format("{0,-40} Type: {1}",
					typItem.FullName,
					typItem.IsClass ? "Class" :
					typItem.IsEnum ? "Enum" :
					typItem.IsGenericParameter ? "Generic Parameter" :
					typItem.IsGenericType ? "Generic Type" :
					typItem.BaseType.FullName));

				if (typItem.IsEnum)
				{
					Array aValues = typItem.GetEnumValues();
					foreach(var item in aValues)
					{
						Trace.WriteLine(String.Format("{0}", (int)item));
					}

					String[] aszEnumNames = typItem.GetEnumNames();
					foreach(String szEnumName in aszEnumNames)
					{
						Trace.WriteLine(szEnumName);
					}
				}
			}

			Type typSample = asmAssembly.GetType("MethodInvoke.Sample");
			if (typSample != null)
			{
				int nResult = -1;
				ConstructorInfo constrInfo = typSample.GetConstructor(new Type[] { });
				Sample sample = constrInfo.Invoke(new Object[] { }) as Sample;

				MethodInfo methInfo = typSample.GetMethod("Add", new Type[] { typeof(int), typeof(int) });
				if (methInfo != null)
				{
					nResult = (int)methInfo.Invoke(sample, new Object[] { 10, 20 });
					Trace.WriteLine(String.Format("Return value = {0}", nResult));
				}

				methInfo = typSample.GetMethod("Add", new Type[] { });
				if (methInfo != null)
				{
					nResult = (int)methInfo.Invoke(sample, null);
					Trace.WriteLine(String.Format("Return value = {0}", nResult));
				}

				PropertyInfo[] propInfos = typSample.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				foreach(PropertyInfo propItem in propInfos)
				{
					Trace.WriteLine(String.Format("Property: {0}", propItem.Name));
				}

				try
				{
					PropertyInfo propVal1 = typSample.GetProperty("Value1");
					if (propVal1 != null)
						propVal1.SetValue(sample, 5);

					PropertyInfo propVal2 = typSample.GetProperty("Value2");
					if (propVal2 != null)
						propVal2.SetValue(sample, 30);
				}

				catch(System.Exception ex)
				{
					Trace.WriteLine(ex.Message);
				}

				FieldInfo valInfo = typSample.GetField("nValue1", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (valInfo != null)
				{
					Trace.WriteLine(String.Format("Value of 'nValue1': {0}", valInfo.GetValue(sample)));
					valInfo.SetValue(sample, 10);
				}

				nResult = (int)methInfo.Invoke(sample, null);
				Trace.WriteLine(String.Format("Return value = {0}", nResult));

				nResult = (int)typSample.InvokeMember
				(
					"Add",
					BindingFlags.InvokeMethod,
					null,
					sample,
					new Object[] { 20, 30 }
				);

				Trace.WriteLine(String.Format("Return value = {0}", nResult));

				IEnumerable<Attribute> ienumAttribs = typSample.GetCustomAttributes();
				Attribute attSerial = ienumAttribs.Where<Attribute>((att) => att.ToString().Contains("Serializable")).FirstOrDefault<Attribute>();
				if (attSerial != null)
				{
					Trace.WriteLine(String.Format("Attribute: {0}", attSerial.ToString()));
				}
			}
		}
	}
}
