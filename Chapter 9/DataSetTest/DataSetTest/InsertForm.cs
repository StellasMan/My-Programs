using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetTest
{
	public partial class InsertForm : Form
	{
		public InsertForm()
		{
			InitializeComponent();
		}
	}

	public class CustomerInfo
	{
		public bool Validate()
		{
			return	!String.IsNullOrEmpty(m_szCustID.Trim())		&&
					!String.IsNullOrEmpty(m_szCompanyName.Trim())	&&
					!String.IsNullOrEmpty(m_szContactName.Trim());
		}

		public String m_szCustID;
		public String m_szCompanyName;
		public String m_szContactName;
		public String m_szContactTitle;
		public String m_szAddress;
		public String m_szCity;
		public String m_szRegion;
		public String m_szPostalCode;
		public String m_szCountry;
		public String m_szPhone;
		public String m_szFax;
	}
}
