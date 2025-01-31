using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Database_Test
{
	public partial class dbTestForm : Form
	{
		public dbTestForm()
		{
			InitializeComponent();
		}

		private void OnStart(Object sender, EventArgs e)
		{
			String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand sqlCmd = new SqlCommand("SELECT * FROM customers", connection);
				connection.Open();

				SqlDataReader sqlReader = sqlCmd.ExecuteReader();

				// Call Read before accessing data.
				 LinkedList<Customer> llstCustomers = new LinkedList<Customer>();
				if (sqlReader.HasRows)
				{
					Customer custTest = new Customer();
					PropertyInfo[] apropInfos = custTest.GetType().GetProperties();

					while (LoadClassFromSQLDataReader(custTest, sqlReader))
					{
						System.Diagnostics.Trace.WriteLine(String.Format("{0}", custTest.ContactName));
						llstCustomers.AddLast(custTest);
						custTest = new Customer();
					}
				}

				// Call Close when done reading.
				sqlReader.Close();

				DisplayCustomers(llstCustomers);
			}
		}

		private void DisplayCustomers(LinkedList<Customer> llCustList)
		{
			dgvCustGrid.Rows.Clear();

			foreach(Customer custItem in llCustList)
			{
				// Name, Address, City, State, Zip, Country
				String[] aszRowData = new String[6];

				aszRowData[0] = custItem.ContactName;
				aszRowData[1] = custItem.Address;
				aszRowData[2] = custItem.City;
				aszRowData[3] = custItem.State;
				aszRowData[4] = custItem.ZipCode;
				aszRowData[5] = custItem.Country;

				dgvCustGrid.Rows.Add(aszRowData);
			}
		}

		private bool LoadClassFromSQLDataReader(Object objClass, SqlDataReader sqlReader)
		{
			Type typOfClass = objClass.GetType();
			PropertyInfo[] propInfos = typOfClass.GetProperties();

			IEnumerable<Attribute> ienumAttrib = typOfClass.GetCustomAttributes();
			Attribute[] aattAttribs = Enumerable.ToArray<Attribute>(ienumAttrib);

			bool bRetVal = sqlReader.Read();
			if (bRetVal)
			{
				for (int nCol=0; nCol<sqlReader.FieldCount; nCol++)
				{
					String szColName = sqlReader.GetName(nCol);

					IEnumerable<DataMappingAttribute> queryGetAttrib =
						from x in aattAttribs
						where ((DataMappingAttribute)x).DBFieldName == szColName
						select x as DataMappingAttribute;

					DataMappingAttribute attDataAttrib = queryGetAttrib.FirstOrDefault<DataMappingAttribute>();
					PropertyInfo propInfo = Array.Find(propInfos, (pInfoItem) => ((attDataAttrib != null) && (pInfoItem.Name == attDataAttrib.PropertyName)) || (pInfoItem.Name == szColName));
					if (propInfo != null)
					{
						Object objValue = sqlReader.GetValue(nCol);
						if (objValue != DBNull.Value)
							propInfo.SetValue(objClass, objValue);
					}
				}
			}

			return bRetVal;
		}
	}
}
