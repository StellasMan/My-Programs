using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolTest
{
	public class Person
	{
		public Person() { m_szFName = ""; }
		public Person(String szFName) { m_szFName = szFName; }

		public String FName
		{
			get { return m_szFName;  }
		}

		private String m_szFName;
	}
}
