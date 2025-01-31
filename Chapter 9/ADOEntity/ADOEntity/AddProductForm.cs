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
	public class ComboPair
	{
		public ComboPair(String sName, int nID)
		{
			m_sName = sName;
			m_nId = nID;
		}

		public String Name
		{
			get { return m_sName; }
		}

		public Int32 ID
		{
			get { return m_nId; }
		}

		private String m_sName;
		private Int32 m_nId;
	}

	public partial class AddProductForm : Form
	{
		public AddProductForm()
		{
			Initialize();
			m_prodItem = new Product();
		}

		public AddProductForm(Product prodItem)
		{
			Initialize();

			m_prodItem = prodItem;
			this.Text = "Update Product";
			btnAdd.Text = "Up&date";

			DisplayData();
		}

		private void Initialize()
		{
			InitializeComponent();

			PopulateCategories();
			PopulateSuppliers();
		}

		private void PopulateCategories()
		{
			cmbCategory.DisplayMember = "CategoryName";
			cmbCategory.ValueMember = "CategoryID";
			using (NorthWindEntities db = new NorthWindEntities())
			{
				cmbCategory.BeginUpdate();
				var catIQDataSet = from catRcds in db.Categories
								   select catRcds;

				cmbCategory.Items.Clear();
				m_dctCategoryToID.Clear();
				foreach (Category catRecord in catIQDataSet)
				{
					int nIndx = cmbCategory.Items.Add(catRecord);
					m_dctCategoryToID.Add(catRecord.CategoryName, catRecord.CategoryID);
				}

				cmbCategory.SelectedItem = (cmbCategory.Items.Count > 0) ? cmbCategory.Items[0] : null;
				cmbCategory.EndUpdate();
			}
		}

		private void PopulateSuppliers()
		{
			cmbSupplier.DisplayMember = "CompanyName";
			cmbSupplier.ValueMember = "SupplierID";
			using (NorthWindEntities db = new NorthWindEntities())
			{
				cmbSupplier.BeginUpdate();
				var supplierIQDataSet = from supplierRcds in db.Suppliers
										select supplierRcds;

				cmbSupplier.Items.Clear();
				m_dctSupplierToID.Clear();
				foreach (Supplier supplierRecord in supplierIQDataSet)
				{
					int nIndx = cmbSupplier.Items.Add(supplierRecord);
					m_dctCategoryToID.Add(supplierRecord.CompanyName, supplierRecord.SupplierID);
				}

				cmbSupplier.SelectedItem = (cmbSupplier.Items.Count > 0) ? cmbSupplier.Items[0] : null;
				cmbSupplier.EndUpdate();
			}
		}

		private void OnAdd(object sender, EventArgs e)
		{
			SaveData();
		}

		private void SaveData()
		{
			m_prodItem.ProductName = txtProdName.Text;

			Supplier supplier = cmbSupplier.SelectedItem as Supplier;
			Category category = cmbCategory.SelectedItem as Category;

			m_prodItem.SupplierID = supplier.SupplierID;
			m_prodItem.CategoryID = category.CategoryID;

			m_prodItem.QuantityPerUnit = (txtQtyPerUnit.Text.Trim().Length > 0) ? txtQtyPerUnit.Text.Trim() : null;

			decimal decItemValue = 0;
			m_prodItem.UnitPrice = null;
			if (mskCurrencyTextBox.TryGetValue(out decItemValue))
				m_prodItem.UnitPrice = decItemValue;

			decItemValue = 0;
			m_prodItem.UnitsInStock = null;
			if (mskUnitsInStock.TryGetValue(out decItemValue))
				m_prodItem.UnitsInStock = (short)decItemValue;

			decItemValue = 0;
			m_prodItem.UnitsOnOrder = null;
			if (mskUnitsOnOrder.TryGetValue(out decItemValue))
				m_prodItem.UnitsOnOrder = (short)decItemValue;

			decItemValue = 0;
			m_prodItem.ReorderLevel = null;
			if (mskReorderLevel.TryGetValue(out decItemValue))
				m_prodItem.ReorderLevel = (short)decItemValue;

			m_prodItem.Discontinued = chkDiscontinued.Checked;
		}

		private void DisplayData()
		{
			txtProdName.Text = m_prodItem.ProductName;

			cmbSupplier.SelectedItem = null;
			foreach (Supplier supItem in cmbSupplier.Items)
			{
				if (supItem.SupplierID == m_prodItem.SupplierID)
				{
					cmbSupplier.SelectedItem = supItem;
					break;
				}
			}

			cmbCategory.SelectedItem = null;
			foreach (Category catItem in cmbCategory.Items)
			{
				if (catItem.CategoryID == m_prodItem.CategoryID)
				{
					cmbCategory.SelectedItem = catItem;
					break;
				}
			}

			txtQtyPerUnit.Text = m_prodItem.QuantityPerUnit;
			mskCurrencyTextBox.Text = (m_prodItem.UnitPrice != null) ? String.Format("{0}", m_prodItem.UnitPrice) : "";
			mskUnitsInStock.Text = (m_prodItem.UnitsInStock != null) ? String.Format("{0}", m_prodItem.UnitsInStock) : "";
			mskUnitsOnOrder.Text = (m_prodItem.UnitsOnOrder != null) ? String.Format("{0}", m_prodItem.UnitsOnOrder) : "";
			mskReorderLevel.Text = (m_prodItem.ReorderLevel != null) ? String.Format("{0}", m_prodItem.ReorderLevel) : "";
			chkDiscontinued.Checked = m_prodItem.Discontinued;
		}

		public Product GetProduct
		{
			get { return m_prodItem; }
		}

		private Dictionary<String, Int32> m_dctCategoryToID = new Dictionary<String, Int32>();
		private Dictionary<String, Int32> m_dctSupplierToID = new Dictionary<String, Int32>();

		private Product m_prodItem = null;
	}
}
