using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOEntity
{
	public partial class CategoriesForm : Form
	{
		public CategoriesForm()
		{
			InitializeComponent();
			this.SizeGripStyle = SizeGripStyle.Show;

			lstvwCategories.View = View.Details;
			lstvwCategories.GridLines = true;
			lstvwCategories.MultiSelect = false;
			lstvwCategories.FullRowSelect = true;

			lstvwCategories.BeginUpdate();
			lstvwCategories.Columns.Clear();

			foreach (String sCol in new String[] { "Product", "CategoryName", "Category ID" })
			{
				ColumnHeader colHdr = lstvwCategories.Columns.Add(sCol);
				colHdr.TextAlign = HorizontalAlignment.Center;
				colHdr.Width = (lstvwCategories.Width / 3) - 1;
			}

			lstvwCategories.EndUpdate();

			ShowProducts();
		}

		private void OnDisplay(Object sender, EventArgs e)
		{
			ShowProducts();
		}

		private void ShowProducts()
		{
			lstvwCategories.BeginUpdate();
			lstvwCategories.Items.Clear();

			using (NorthWindEntities db = new NorthWindEntities())
			{
				IQueryable<Product> prodIQDataSet = 
						from catRcds in db.Categories
						join prodRcds in db.Products
						on catRcds.CategoryID equals prodRcds.CategoryID
						select prodRcds;
				var prodIQOrdered = prodIQDataSet.OrderBy(prod => prod.Category.CategoryName);
				foreach (Product prodRecord in prodIQOrdered)
				{
					System.Diagnostics.Debug.WriteLine(String.Format("Product Name: {0}, Category Name(ID): {1}({2})", prodRecord.CategoryID, prodRecord.Category.CategoryName, prodRecord.CategoryID));
					ListViewItem lstVwItem = lstvwCategories.Items.Add(prodRecord.ProductName);
					lstVwItem.Tag = prodRecord.ProductID;
					lstVwItem.SubItems.Add(prodRecord.Category.CategoryName);
					lstVwItem.SubItems.Add(String.Format("{0}", prodRecord.CategoryID));
				}
			}

			lstvwCategories.EndUpdate();
		}

		private void OnAdd(Object sender, EventArgs e)
		{
			AddProduct();
			ShowProducts();
		}

		private void OnDelete(Object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection viewColl = lstvwCategories.SelectedItems;

			LinkedList<int> llstItems = new LinkedList<int>();
			foreach(ListViewItem collItem in viewColl)
			{
				llstItems.AddLast((int)collItem.Tag);
			}

			DeleteItems(llstItems);
			ShowProducts();
		}

		private void OnHistory(Object sender, EventArgs e)
		{
			ShowOrderHistory();
		}

		private void AddProduct()
		{
			AddProductForm frmAddProd = new AddProductForm();
			if (DialogResult.OK == frmAddProd.ShowDialog())
			{
				Product prodItem = frmAddProd.GetProduct;
				if (prodItem != null)
				{
					using (NorthWindEntities db = new NorthWindEntities())
					{
						db.Products.Add(prodItem);
						db.SaveChanges();
					}
				}
			}
		}

		private void DeleteItems(LinkedList<int> llstItems)
		{
			using (NorthWindEntities db = new NorthWindEntities())
			{
				IQueryable<Product> iqueryProducts = 
					from prodRcd in db.Products
					where llstItems.Contains(prodRcd.ProductID)
					select prodRcd;

				foreach (Product prodRecord in iqueryProducts)
				{
					db.Products.Remove(prodRecord);
				}

				db.SaveChanges();
			}
		}

		private void OnModify(Object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection viewColl = lstvwCategories.SelectedItems;

			if (viewColl.Count > 0)
			{
				UpdateItem((int)viewColl[0].Tag);
				ShowProducts();
			}
		}

		private void UpdateItem(int productId)
		{
			using (NorthWindEntities db = new NorthWindEntities())
			{
				IQueryable<Product> iqueryProducts =
					from prodRcd in db.Products
					where productId == prodRcd.ProductID
					select prodRcd;

				Product prodRecord = iqueryProducts.FirstOrDefault();
				if (prodRecord != null)
				{
					AddProductForm frmAddProd = new AddProductForm(prodRecord);
					if (DialogResult.OK == frmAddProd.ShowDialog())
					{
						db.SaveChanges();
					}
				}
			}
		}

		private void ShowOrderHistory()
		{
			using (NorthWindEntities db = new NorthWindEntities())
			{
				System.Data.Entity.Core.Objects.ObjectResult<CustOrderHist_Result> CustOrderHistory = db.CustOrderHist("ALFKI");
				CustomerHistoryForm frmHistory = new CustomerHistoryForm();
				frmHistory.ShowDialog(this);
			}
		}
	}
}
