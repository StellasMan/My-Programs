using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBReflection
{
	[System.AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
	public class DataMappingAttribute : System.Attribute
	{
		public DataMappingAttribute() {}

		public DataMappingAttribute(String szFieldName, String szPropertyName)
		{
			m_szFieldName = szFieldName;
			m_szPropertyName = szPropertyName;
		}

		public String m_szFieldName;
		public String m_szPropertyName;
	}
}
