using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTest
{
	public class TreeItemNode
	{
		public TreeItemNode()
		{
			m_sNodeName = String.Empty;
			m_bRoot = false;
		}

		public TreeItemNode(String sNodeName, bool bRoot=false)
		{
			m_sNodeName = sNodeName;
			m_bRoot = bRoot;
		}

		public void AddChild(TreeItemNode tnChild)
		{
			m_lstChildren.AddLast(tnChild);
		}

		public TreeItemNode RemoveChild(String sNodeName)
		{
			TreeItemNode tnItem = m_lstChildren.Where((t) => t.m_sNodeName == sNodeName).FirstOrDefault();
			if (tnItem != null)
			{
				m_lstChildren.Remove(tnItem);
			}

			return tnItem;
		}

		public String NodeName
		{
			get => m_sNodeName;
		}

		public Array Children
		{
			get => m_lstChildren.ToArray<TreeItemNode>();
		}

		public bool IsRoot
		{
			get => m_bRoot;
		}

		protected String m_sNodeName;
		protected LinkedList<TreeItemNode> m_lstChildren = new LinkedList<TreeItemNode>();
		protected bool m_bRoot = false;
	}
}
