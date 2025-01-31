using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Test
{
	[System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class DataMappingAttribute : System.Attribute
	{
		public DataMappingAttribute(String sDBName, String sClassName)
		{
			DBFieldName = sDBName;
			PropertyName = sClassName;
		}

		public String DBFieldName { get; set; }
		public String PropertyName { get; set; }
	}

	[DataMapping("CustomerID", "ID")]
	[DataMapping("Region", "State")]
	[DataMapping("PostalCode", "ZipCode")]	
	public class Customer
	{
		public String ID
		{
			get;
			set;
		}

		public String CompanyName
		{
			get;
			set;
		}

		public String ContactName
		{
			get;
			set;
		}

		public String ContactTitle
		{
			get;
			set;
		}

		public String Address
		{
			get;
			set;
		}

		public String City
		{
			get;
			set;
		}

		public String State
		{
			get;
			set;
		}

		public String ZipCode
		{
			get;
			set;
		}

		public String Country
		{
			get;
			set;
		}

		public String Phone
		{
			get;
			set;
		}

		public String Fax
		{
			get;
			set;
		}
	}
}
