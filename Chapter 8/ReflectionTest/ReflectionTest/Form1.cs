using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace ReflectionTest
{
	public struct STRNOTE
	{
		public STRNOTE(int nFreq, int nDurMs, int nDelay)
		{
			m_nFreq = nFreq;
			m_nDurMs = nDurMs;
			m_nDelay = nDelay;
		}

		public int m_nFreq;
		public int m_nDurMs;
		public int m_nDelay;
	};

	public partial class ReflectionTestForm : Form
	{
		public ReflectionTestForm()
		{
			InitializeComponent();
		}

		private void OnLoad(Object sender, EventArgs e)
		{
			STRNOTE[] aNotes =
			{
				new STRNOTE(264,1000, 500),
				//new STRNOTE(264,250, 500),
				//new STRNOTE(264,250,250),
				//new STRNOTE(297,1000,250),
				//new STRNOTE(264,1000,250),
				//new STRNOTE(352,1000,250),
				//new STRNOTE(330,2000,500)
				//new STRNOTE(264,250,500),
				//new STRNOTE(264,250,250),
				//new STRNOTE(297,1000,250),
				//new STRNOTE(264,1000,250),
				//new STRNOTE(396,1000,250),
				//new STRNOTE(352,2000,500),
				//new STRNOTE(264,250,500),
				//new STRNOTE(264,250,250),
				//new STRNOTE(264,1000,250),
				//new STRNOTE(440,1000,250),
				//new STRNOTE(352,500,250),
				//new STRNOTE(352,250,250),
				//new STRNOTE(330,1000,250),
				//new STRNOTE(297,2000,500),
				//new STRNOTE(466,250,500),
				//new STRNOTE(466,250,250),
				//new STRNOTE(440,1000,250),
				//new STRNOTE(352,1000,250),
				//new STRNOTE(396,1000,250),
				//new STRNOTE(352,2000,250)
			};

			txtName.Clear();
			String fileName = GetAssmblyName();
			if (!String.IsNullOrEmpty(fileName))
			{
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				Action<Object> actGetInfo = (Object obj) =>
					{
						String sFileName = obj as String;
						GetInfo(sFileName);
					};

				Task tskInfo = new Task(actGetInfo, fileName, cancellationTokenSource.Token);
				tskInfo.ContinueWith(new Action<Task>(NotifyComplete))
				.ContinueWith
				(	new Action<Task>
					(
						(t) => 
						{
							foreach (STRNOTE strItem in aNotes)
							{
								Console.Beep(strItem.m_nFreq, strItem.m_nDurMs);
								// Thread.Sleep(strItem.m_nDelay);
							}
						}
					)
				);

				tskInfo.Start();
			}
		}

		private void GetInfo(String sFileName)
		{
			m_asmAssmbly = Assembly.LoadFile(sFileName);

			AssemblyName asmName = m_asmAssmbly.GetName();
			Trace.WriteLine(String.Format("Assembly Name: {0}", asmName.FullName));
			txtName.Invoke(new Action(() => txtName.Text = asmName.FullName));

			TreeItemNode tnRoot = new TreeItemNode("<root>", true);	// One and only <root> node
			IEnumerable<TypeInfo> infoTypes = m_asmAssmbly.DefinedTypes;
			int nCount = 0;
			foreach (TypeInfo itemInfo in infoTypes)
			{
				TreeItemNode tnNode = new TreeItemNode(itemInfo.Name);
				Trace.WriteLine(String.Format("Item {0}: Name {1}; Base Type Name: {2}", ++nCount, itemInfo.Name, itemInfo.BaseType.Name));

				GetItemInfo(itemInfo, tnNode);

				tnRoot.AddChild(tnNode);
				Type typeItem = itemInfo.UnderlyingSystemType;
				Trace.WriteLine(String.Format("Underlying type: {0}", typeItem.ToString()));
			}

			IEnumerable<Attribute> ienumAttribs = m_asmAssmbly.GetCustomAttributes();
			foreach(Attribute item in ienumAttribs)
			{
				Trace.WriteLine(String.Format("Item: {0}", item.ToString()));
			}

			Type[] aTypes = m_asmAssmbly.GetExportedTypes();
			foreach (Type item in aTypes)
			{
				Trace.WriteLine(String.Format("Type {0}", item.Name));
			}

			IEnumerable<TypeInfo> enumTypeInfos = m_asmAssmbly.DefinedTypes;
			foreach (TypeInfo item in enumTypeInfos)
			{
				Trace.WriteLine(String.Format("Type {0}", item.Name));
			}

			AssemblyName[] aasmName = m_asmAssmbly.GetReferencedAssemblies();
			foreach(AssemblyName item in aasmName)
			{
				Trace.WriteLine(String.Format("Assembly Name: {0}; Version: {1}", item.Name, item.Version));
			}

			tvReflect.Invoke
			(
				new Action<TreeItemNode>
				(
					(TreeItemNode t) =>
					{
						UpdateTreeView(t);
					}
				),
				tnRoot
			);

			Type tyAttrib = typeof(AttribTest);

			Object[] aObjAttribs = tyAttrib.GetCustomAttributes(false);
			foreach(Object objItem in aObjAttribs)
			{
				MyCustomAttribute attribItem = objItem as MyCustomAttribute;
				if (attribItem != null)
				{
					Trace.WriteLine(String.Format("Attribute Name: {0}; ID: {1}", attribItem.ToString(), attribItem.TypeId));
					Trace.WriteLine(String.Format("Property1: {0}", attribItem.Property1));
					Trace.WriteLine(String.Format("Property2: {0}", attribItem.Property2));
					Trace.WriteLine(String.Format("Property3: {0}", attribItem.Property3));
				}
			}
		}

		private void GetItemInfo(TypeInfo typeItem, TreeItemNode tnNode)
		{
			if (typeItem.IsClass)
			{
				GetClassInfo(typeItem, tnNode);
			}
			else if (typeItem.IsEnum)
			{
				GetEnumInfo(typeItem, tnNode);
			}
			else if (typeItem.IsValueType)
			{
				GetValueInfo(typeItem, tnNode);
			}
			else if (typeItem.IsInterface)
			{
				GetInterfaceInfo(typeItem, tnNode);
			}
			else if (typeItem.IsArray)
			{
				GetArrayInfo(typeItem, tnNode);
			}
		}

		private void GetClassInfo(TypeInfo typeItem, TreeItemNode tnNodeParent)
		{
			// Show class constructors
			ConstructorInfo[] constructorInfos = typeItem.GetConstructors();
			TreeItemNode tnCTORNode = new TreeItemNode("Constructors");
			tnNodeParent.AddChild(tnCTORNode);
			foreach(ConstructorInfo cinfoItem in constructorInfos)
			{
				StringBuilder sb = new StringBuilder(typeItem.Name + "(");
				ParameterInfo[] parameterInfos = cinfoItem.GetParameters();
				foreach(ParameterInfo piItem in parameterInfos)
				{
					sb.Append(piItem.Name + ",");
				}

				if (parameterInfos.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append(")");
				tnCTORNode.AddChild(new TreeItemNode(sb.ToString()));
			}

			// Show class methods
			TreeItemNode tnMethodNode = new TreeItemNode("Methods");
			tnNodeParent.AddChild(tnMethodNode);
			IEnumerable<MethodInfo> ienumMethods = typeItem.GetMethods();
			foreach(MethodInfo miItem in ienumMethods)
			{
				StringBuilder sb = new StringBuilder(String.Format("{0} {1}(", miItem.ReturnType.ToString(), miItem.Name));
				ParameterInfo[] parameterInfos = miItem.GetParameters();
				foreach(ParameterInfo piItem in parameterInfos)
				{
					sb.Append(String.Format("{0} {1},", piItem.ParameterType.ToString(), piItem.Name));
				}
				if (parameterInfos.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append(")");
				tnMethodNode.AddChild(new TreeItemNode(sb.ToString()));
			}

			// Show class methods
			MemberInfo[] memberInfos = typeItem.GetMembers();
			TreeItemNode tnMemberNode = new TreeItemNode("Members");
			tnNodeParent.AddChild(tnMemberNode);
			foreach (MemberInfo memItem in ienumMethods)
			{
				String csMemInfo = String.Format("{0} {1}", memItem.MemberType.ToString(), memItem.Name);
				tnMethodNode.AddChild(new TreeItemNode(csMemInfo));
			}

			// Show class properties
			PropertyInfo[] propertyInfos = typeItem.GetProperties();
			TreeItemNode tnPropertyNode = new TreeItemNode("Properties");
			tnNodeParent.AddChild(tnPropertyNode);
			foreach (PropertyInfo piItem in propertyInfos)
			{
				String csPropInfo = String.Format("{0} {1}", piItem.PropertyType.ToString(), piItem.Name);
				tnPropertyNode.AddChild(new TreeItemNode(csPropInfo));
			}
		}

		private void GetEnumInfo(TypeInfo typeItem, TreeItemNode tnNode)
		{

		}

		private void GetValueInfo(TypeInfo typeItem, TreeItemNode tnNode)
		{

		}

		private void GetInterfaceInfo(TypeInfo typeItem, TreeItemNode tnNode)
		{

		}

		private void GetArrayInfo(TypeInfo typeItem, TreeItemNode tnNode)
		{

		}

		private void UpdateTreeView(TreeItemNode tnRoot)
		{
			tvReflect.BeginUpdate();

			tvReflect.ShowRootLines = true;
			tvReflect.Nodes.Clear();
			AddTreeNode(tnRoot, null);

			tvReflect.EndUpdate();
		}

		private void AddTreeNode(TreeItemNode tItemNode, TreeNode tnParent)
		{
			TreeNode tnTemp = null;
			if (tnParent == null)
			{
				if (!tItemNode.IsRoot)
					tnTemp = tvReflect.Nodes.Add(tItemNode.NodeName);
			}
			else
			{
				tnTemp = tnParent.Nodes.Add(tItemNode.NodeName);
			}

			foreach (TreeItemNode tnItem in tItemNode.Children)
			{
				AddTreeNode(tnItem, tnTemp);
			}
		}

		private void NotifyComplete(Task tskCompleted)
		{
			Console.Beep();
		}

		private String GetAssmblyName()
		{
			String filePath = String.Empty;
			String dirInitial = @"c:\";
			String fileInitial = String.Empty;

			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"MCSD Programs\ReflectionTest");
			if (key == null)
			{
				key = Registry.CurrentUser.CreateSubKey(@"MCSD Programs\ReflectionTest");
			}
			else
			{
				filePath = key.GetValue("File") as String;
				dirInitial = Path.GetDirectoryName(filePath);
				fileInitial = Path.GetFileName(filePath);
			}
			key.Close();

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = dirInitial;
				openFileDialog.FileName = fileInitial;
				openFileDialog.Filter = "Executable files (*.exe)|*.exe|Dynamic Link Libs (*.dll)|*.dll|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 3;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;

					key = Registry.CurrentUser.OpenSubKey(@"MCSD Programs\ReflectionTest", true);
					key.SetValue("File", filePath);
					key.Close();
				}
			}

			return filePath;
		}

		private void OnCreate(Object sender, EventArgs e)
		{
			TreeNode tnNode = tvReflect.SelectedNode;
			if (m_asmAssmbly != null)
			{
				Object objInstance = m_asmAssmbly.CreateInstance(tnNode.Text);
				if (objInstance != null)
				{
					Trace.WriteLine("Created instance of {0}", objInstance.ToString());
				}
			}
		}

		Assembly m_asmAssmbly = null;
	}
}
