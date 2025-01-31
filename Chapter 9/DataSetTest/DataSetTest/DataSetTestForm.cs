using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataSetTest
{
	public partial class DataSetTestForm : Form
	{
		public DataSetTestForm()
		{
			InitializeComponent();

			Thread thrdQuery = new Thread
			(
				() =>
				{
					FillDataSet();
				}
			);

			thrdQuery.Name = "Query Thread";
			thrdQuery.Priority = ThreadPriority.AboveNormal;
			thrdQuery.IsBackground = true;
			thrdQuery.Start();
		}

		private void OnInsert(object sender, EventArgs e)
		{
			InsertForm frmInsert = new InsertForm();
			DialogResult dlgResult = frmInsert.ShowDialog(this);
			if (dlgResult == DialogResult.OK)
			{
				CustomerInfo custInfo = new CustomerInfo();
				custInfo.m_szCustID = frmInsert.CustomerIDTxt;
				custInfo.m_szCompanyName = frmInsert.CompanyNameTxt;
				custInfo.m_szContactName = frmInsert.ContactNameTxt;
				custInfo.m_szContactTitle = frmInsert.ContactTitleTxt;
				custInfo.m_szAddress = frmInsert.AddressTxt;
				custInfo.m_szCity = frmInsert.CityTxt;
				custInfo.m_szRegion = frmInsert.RegionTxt;
				custInfo.m_szPostalCode = frmInsert.PostalCodeTxt;
				custInfo.m_szCountry = frmInsert.CountryTxt;
				custInfo.m_szPhone = frmInsert.PhoneTxt;
				custInfo.m_szFax = frmInsert.FaxTxt;

				if (custInfo.Validate())
				{
					BackgroundWorker bkWorker = new BackgroundWorker();
					bkWorker.WorkerReportsProgress = true;
					bkWorker.WorkerSupportsCancellation = true;
					bkWorker.DoWork += BkWorkInsertRecord;
					bkWorker.ProgressChanged += BkWorkProgressChanged;
					bkWorker.RunWorkerCompleted += BkWorkInsertCompleted;
					bkWorker.RunWorkerAsync(new Tuple<CustomerInfo, BackgroundWorker>(custInfo, bkWorker));
				}
				else
				{
					System.Windows.Forms.MessageBox.Show("Error: Incomplete data for customer.\nUnable to insert customer record.");
				}
			}
		}

		private void OnDelete(object sender, EventArgs e)
		{
			LinkedList<String> lstSelected = new LinkedList<string>();

			foreach(ListViewItem lstItem in lstvwCustomers.Items)
			{
				if (lstItem.Selected)
				{
					lstSelected.AddLast(lstItem.Text);
				}
			}

			ThreadPool.QueueUserWorkItem(DeleteObject, lstSelected);
		}

		private void DeleteObject(Object objItem)
		{
			LinkedList<String> lstIds = objItem as LinkedList<String>;
			Trace.Write("");

			StringBuilder sb = new StringBuilder();
			foreach(String sItem in lstIds)
				sb.Append(String.Format("{0}, ", sItem));

			if (sb.Length > 0)
			{
				sb.Remove(sb.Length - 2, 2);
				Trace.WriteLine(String.Format("Deleting records with company IDs {{{0}}}", sb.ToString()));

				try
				{
					String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
					using (SqlConnection sqlConnection = new SqlConnection(connectionString))
					{
						sqlConnection.Open();
						String szInsertCmd = "DELETE FROM CUSTOMERS WHERE CustomerID = @CustomerID";
						SqlCommand cmdDelete = new SqlCommand(szInsertCmd, sqlConnection);

						cmdDelete.CommandType = CommandType.Text;
						cmdDelete.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.NChar, 5, "CustomerID"));

						m_sqlDataAdapter.DeleteCommand = cmdDelete;

						foreach(String sItem in lstIds)
						{
							DataRow dataRow = m_custDataSet.Tables[0].Rows.Find(sItem);
							if (dataRow != null)
								dataRow.Delete();
						}

						m_sqlDataAdapter.Update(m_custDataSet.Tables[0]);

						FillDataSet();
					}
				}
				catch (System.Exception ex)
				{
					Trace.WriteLine(String.Format("Exception 0x{0,8:X} attempting to delete record.\n{1}", ex.HResult, ex.Message));
				}

			}
			else
			{
				Trace.WriteLine("No records to delete");
			}
		}

		private void BkWorkInsertRecord(object sender, DoWorkEventArgs e)
		{
			Tuple<CustomerInfo, BackgroundWorker> tupleParam = e.Argument as Tuple<CustomerInfo, BackgroundWorker>;
			CustomerInfo custInfo = tupleParam.Item1;
			BackgroundWorker bkWorkerLocal = tupleParam.Item2;

			String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
			if (m_custDataSet.Tables.Count > 0)
			{
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(connectionString))
					{
						sqlConnection.Open();
						String szInsertCmd = "INSERT INTO CUSTOMERS (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES(@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)";
						SqlCommand cmdInsert = new SqlCommand(szInsertCmd, sqlConnection);

						cmdInsert.CommandType = CommandType.Text;
						cmdInsert.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.NChar, 5, "CustomerID"));
						cmdInsert.Parameters.Add(new SqlParameter("@CompanyName", SqlDbType.NVarChar, 40, "CompanyName"));
						cmdInsert.Parameters.Add(new SqlParameter("@ContactName", SqlDbType.NVarChar, 30, "ContactName"));
						cmdInsert.Parameters.Add(new SqlParameter("@ContactTitle", SqlDbType.NVarChar, 30, "ContactTitle"));
						cmdInsert.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 60, "Address"));
						cmdInsert.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 15, "City"));
						cmdInsert.Parameters.Add(new SqlParameter("@Region", SqlDbType.NVarChar, 15, "Region"));
						cmdInsert.Parameters.Add(new SqlParameter("@PostalCode", SqlDbType.NVarChar, 10, "PostalCode"));
						cmdInsert.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 15, "Country"));
						cmdInsert.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 24, "Phone"));
						cmdInsert.Parameters.Add(new SqlParameter("@Fax", SqlDbType.NVarChar, 24, "Fax"));

						m_sqlDataAdapter.InsertCommand = cmdInsert;

						DataRow dtaRow = m_custDataSet.Tables[0].NewRow();
						// DataRow dtaRow = m_custDataSet.Tables[0].Rows[0];

						dtaRow["CustomerID"] = custInfo.m_szCustID;
						dtaRow["CompanyName"] = custInfo.m_szCompanyName;
						dtaRow["ContactName"] = custInfo.m_szContactName;
						dtaRow["ContactTitle"] = custInfo.m_szContactTitle;
						dtaRow["Address"] = custInfo.m_szAddress;
						dtaRow["City"] = custInfo.m_szCity;
						dtaRow["Region"] = custInfo.m_szRegion;
						dtaRow["PostalCode"] = custInfo.m_szPostalCode;
						dtaRow["Country"] = custInfo.m_szCountry;
						dtaRow["Phone"] = custInfo.m_szPhone;
						dtaRow["Fax"] = custInfo.m_szFax;

						m_custDataSet.Tables[0].Rows.Add(dtaRow);

						if (bkWorkerLocal != null)
							bkWorkerLocal.ReportProgress(50);

						m_sqlDataAdapter.Update(m_custDataSet.Tables[0]);

						FillDataSet();

						if (bkWorkerLocal != null)
							bkWorkerLocal.ReportProgress(100);

						e.Result = 0;
					}
				}
				catch(System.Exception ex)
				{
					Trace.WriteLine(String.Format("Exception 0x{0,8:X} attempting to insert record.\n{1}", ex.HResult, ex.Message));
					if (bkWorkerLocal != null)
						bkWorkerLocal.ReportProgress(100);

					e.Result = ex.HResult;
				}
			}
		}

		private void BkWorkProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			Trace.WriteLine(String.Format("BkWorker Progress: {0}% Complete", e.ProgressPercentage));
		}

		private void BkWorkInsertCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Trace.WriteLine(String.Format("BkWorker Complete: Result=0x{0,8:X}", e.Result));
		}

		private void FillDataSet()
		{
			String connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				m_sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Customers", sqlConnection);
				m_custDataSet = new DataSet();
				m_sqlDataAdapter.Fill(m_custDataSet, "dbo.Customers");
				sqlConnection.Close();

				DataTable dbTable = m_custDataSet.Tables[0];
				dbTable.PrimaryKey = new DataColumn[] { m_custDataSet.Tables[0].Columns["CustomerID"] };
				List<String> lstData = new List<string>(dbTable.Columns.Count);
				foreach (DataColumn dtaColumn in dbTable.Columns)
				{
					lstData.Add(dtaColumn.ColumnName);
					Trace.Write(String.Format("{0} ", dtaColumn.ColumnName));
				}
				Trace.WriteLine("");

				lstvwCustomers.Invoke
				(
					new Action<List<String>>
					(
						(List<String> lstCols) =>
						{
							lstvwCustomers.BeginUpdate();
							lstvwCustomers.Columns.Clear();
							lstvwCustomers.Items.Clear();

							foreach (String sCol in lstCols)
							{
								ColumnHeader colHdr = lstvwCustomers.Columns.Add(sCol);
							}
						}
					), 
					lstData
				);

				foreach (DataRow row in dbTable.Rows)
				{
					lstData.Clear();
					foreach(Object objValue in row.ItemArray)
					{
						Trace.Write(String.Format("{0} ", objValue));
						lstData.Add(String.Format("{0}", objValue));
					}
					Trace.WriteLine("");

					lstvwCustomers.Invoke
					(
						new Action<List<String>>
						(
							(List<String> lstRowData) =>
							{
								if (lstRowData.Count > 0)
								{
									ListViewItem lstVwItem = lstvwCustomers.Items.Add(lstRowData[0]);
									for (int nIx = 1; nIx < lstRowData.Count; nIx++)
									{
										lstVwItem.SubItems.Add(lstRowData[nIx]);
									}
								}
							}
						), 
						lstData
					);
				}

				lstvwCustomers.Invoke
				(
					new Action
					(
						() =>
						{
							foreach (ColumnHeader colHeader in lstvwCustomers.Columns)
								colHeader.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

							lstvwCustomers.EndUpdate();
						}
					)
				);
			}
		}

		protected SqlDataAdapter m_sqlDataAdapter;
		protected DataSet m_custDataSet;
	}
}
