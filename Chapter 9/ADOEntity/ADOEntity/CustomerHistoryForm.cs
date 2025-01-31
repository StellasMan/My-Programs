using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOEntity
{
	public partial class CustomerHistoryForm : Form
	{
		public CustomerHistoryForm()
		{
			InitializeComponent();

			lstvwCustomers.View = View.Details;
			lstvwCustomers.MultiSelect = false;
			lstvwCustomers.GridLines = true;
			lstvwCustomers.FullRowSelect = true;
			lstvwCustomers.HideSelection = false;

			lstvwCustomers.Columns.Clear();
			foreach (String sColumn in new String[] { "ID", "Company Name", "Contact", "Region", "Country" })
			{
				lstvwCustomers.Columns.Add(sColumn);
			}

			lstvwHistory.View = View.Details;
			lstvwHistory.MultiSelect = false;
			lstvwHistory.GridLines = true;
			lstvwHistory.FullRowSelect = true;
			lstvwHistory.HideSelection = false;

			lstvwHistory.Columns.Clear();
			foreach (String sColumn in new String[] { "Product Name", "Total" })
			{
				lstvwHistory.Columns.Add(sColumn);
			}

			ShowCustomers();

			lstvwCustomers.Select();
		}

		private void ShowCustomers()
		{
			using (NorthWindEntities db = new NorthWindEntities())
			{
				lstvwCustomers.BeginUpdate();

				lstvwCustomers.Items.Clear();

				foreach (Customer custItem in db.Customers)
				{
					ListViewItem lstvwItem = lstvwCustomers.Items.Add(custItem.CustomerID);
					lstvwItem.SubItems.Add(custItem.CompanyName);
					lstvwItem.SubItems.Add(custItem.ContactName);
					lstvwItem.SubItems.Add(custItem.Region);
					lstvwItem.SubItems.Add(custItem.Country);
				}

				if (lstvwCustomers.Items.Count > 0)
					lstvwCustomers.Items[0].Selected = true;

				ShowHistory();

				lstvwCustomers.EndUpdate();
			}
		}

		private void OnCustomerSelectionChanged(Object sender, EventArgs e)
		{
			ShowHistory();
		}

		private void ShowHistory()
		{
			var lstvwItems = lstvwCustomers.SelectedItems;
			if (lstvwItems.Count > 0)
			{
				String sCustID = lstvwItems[0].Text;
				ShowHistory(sCustID);
			}
		}

		private void ShowHistory(String sCustID)
		{
			lstvwHistory.Items.Clear();
			using (NorthWindEntities db = new NorthWindEntities())
			{
				var custOrderHist = db.CustOrderHist(sCustID);
				foreach (var custHistItem in custOrderHist)
				{
					ListViewItem lstHistItem = lstvwHistory.Items.Add(custHistItem.ProductName);
					lstHistItem.SubItems.Add(String.Format("{0}", custHistItem.Total));
				}
			}
		}

		private void OnClose(Object sender, EventArgs e)
		{
			Close();
		}
	}
}
