using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
	public class Address
	{
		private String m_szAddress1;
		private String m_szAddress2;
		private String m_szCity;
		private String m_szState;
		private String m_szZipCode;

		public Address(String szAddress1, String szAddress2, String szCity, String szState, String szZipCode)
		{
			m_szAddress1 = szAddress1;
			m_szAddress2 = szAddress2;
			m_szCity = szCity;
			m_szState = szState;
			m_szZipCode = szZipCode;
		}

		public Address(Address srcAddress)
		{
			DoCopy(srcAddress);
		}

		private void DoCopy(Address srcAddress)
		{
			m_szAddress1 = srcAddress.m_szAddress1;
			m_szAddress2 = srcAddress.m_szAddress2;
			m_szCity = srcAddress.m_szCity;
			m_szState = srcAddress.m_szState;
			m_szZipCode = srcAddress.ZipCode;
		}

		public String Address1
		{
			get { return m_szAddress1; }
		}

		public String Address2
		{
			get { return m_szAddress2; }
		}

		public String City
		{
			get { return m_szCity; }
		}

		public String State
		{
			get { return m_szState; }
		}

		public String ZipCode
		{
			get { return m_szZipCode; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(m_szAddress1);
			if (!String.IsNullOrEmpty(m_szAddress2))
				sb.AppendLine(m_szAddress2);

			sb.AppendFormat("{0}, {1} {2}", m_szCity, m_szState, m_szZipCode);
			sb.AppendLine();

			return sb.ToString();
		}
	}

	public class Student : IComparable
	{
		private String m_FirstName;
		private String m_LastName;
		private Address m_Address;

		public Student(String FirstName, String LastName, Address addrAddress)
		{
			m_FirstName = FirstName;
			m_LastName = LastName;
			m_Address = new Address(addrAddress);
		}

		public int CompareTo(Object obj)
		{
			int nRetVal = 0;
			Student srcStudent = obj as Student;
			if (srcStudent != null) 
			{
				String sSource = String.Format("{0}|{1}|{2}", srcStudent.LastName, srcStudent.FirstName, srcStudent.Address.ZipCode);
				String sDest = String.Format("{0}|{1}|{2}", LastName, FirstName, Address.ZipCode);
				nRetVal = sDest.CompareTo(sSource);
			}
			return nRetVal;
		}

		public String FirstName
		{
			get { return m_FirstName; }
		}

		public String LastName
		{
			get { return m_LastName; }
		}

		public Address Address
		{
			get { return m_Address; }
		}

		public override String ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0}, {1}\n", m_LastName, m_FirstName);
			sb.AppendLine(m_Address.ToString());

			return sb.ToString();
		}
	}
}
