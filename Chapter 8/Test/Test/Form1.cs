using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataTest;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089");

            Debug.WriteLine(String.Format("Codebase: {0}", myAssembly.CodeBase));
            Debug.WriteLine(String.Format("Location: {0}", myAssembly.Location));
            Debug.WriteLine(String.Format("Full Name: {0}", myAssembly.FullName));
            Debug.WriteLine(String.Format("Type: {0}", myAssembly.GetType()));

            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            Debug.WriteLine(String.Format("Full Name of Assembly: {0}", thisAssembly.FullName));

            CClassProperties clsProps = new CClassProperties("AltaPeakWay");

            Type PropType = typeof(CClassProperties);
            FieldInfo fldInfo = PropType.GetField("Name", BindingFlags.Instance | BindingFlags.NonPublic);
            fldInfo.SetValue("JeffAndStella", );
            Debug.WriteLine("Field value = {0}", fldInfo.Name);


            Type[] aTypes = thisAssembly.GetTypes();
            foreach(Type tyItem in aTypes)
            {
                Debug.WriteLine(String.Format("Assembly Type Name: {0}", tyItem.Name));

                if (tyItem.IsClass)
                {
                    ConstructorInfo[] acConstructors = tyItem.GetConstructors();

                    sbyte sbCtorCount = 1;
                    foreach(ConstructorInfo ctorInfo in acConstructors)
                    {
                        sbyte sbParamCount = 1;
                        ParameterInfo[] aParamInfo = ctorInfo.GetParameters();

                        if (aParamInfo.Length > 0)
                        {
                            foreach (ParameterInfo parItem in aParamInfo)
                            {
                                Debug.WriteLine("Class {0} constructor {1} Parameter {2}: {3}", tyItem.Name, sbCtorCount, sbParamCount, parItem.Name);
                                sbParamCount++;
                            }
                        }
                        else
                        {
                            Debug.WriteLine("Class {0} ctor {1} has no parameters", tyItem.Name, sbCtorCount);
                        }

                        sbCtorCount++;
                    }

                    MemberInfo[] amInfo = tyItem.GetMembers();
                    foreach(MemberInfo memItem in amInfo)
                    {
                        Debug.WriteLine("Class {0} member {1}, Type {2}", tyItem.Name, memItem.Name, memItem.GetType().ToString());
                    }
                }
            }
        }
    }
}
