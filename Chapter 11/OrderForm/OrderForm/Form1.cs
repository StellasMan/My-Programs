using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlatinumDesign.GeneralDataStructures;

namespace OrderForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void OnFormLoad(object sender, EventArgs e)
		{
			InitialzeLocalData();
		}
		private void InitialzeLocalData()
		{
			KeyValuePair<UInt32, String>[] aCityPairs = new KeyValuePair<UInt32, String>[]
			{
				new KeyValuePair<uint, string>(13370, "Programmeria"),
				new KeyValuePair<uint, string>(13371, "Programmeria"),
				new KeyValuePair<uint, string>(13372, "Programmeria"),
				new KeyValuePair<uint, string>(13375, "Bugsville"),
				new KeyValuePair<uint, string>(13376, "Bugsville"),
				new KeyValuePair<uint, string>(13376, "Abend"),
				new KeyValuePair<uint, string>(13377, "Abend"),
				new KeyValuePair<uint, string>(13378, "Abend"),
				new KeyValuePair<uint, string>(13379, "Abend")
			};

			m_dctZipToCity.Clear();
			foreach (var item in aCityPairs)
				m_dctZipToCity.Add(item.Key, item.Value);

			m_lstOrderItems = new List<List<TextBox>>()
			{
				new List<TextBox>() { txtDesc1, txtCost1, txtQty1, txtTotal1 },
				new List<TextBox>() { txtDesc2, txtCost2, txtQty2, txtTotal2 },
				new List<TextBox>() { txtDesc3, txtCost3, txtQty3, txtTotal3 },
				new List<TextBox>() { txtDesc4, txtCost4, txtQty4, txtTotal4 }
			};

			cmbZip.SelectedIndex = -1;
		}

		private void txtFName_TextChanged(object sender, EventArgs e)
		{
			txtFName.BackColor = ValidateInput(sender as TextBox, m_sNameRegExp) ? m_clrOK : m_clrError; ;
		}

		private void txtLName_TextChanged(object sender, EventArgs e)
		{
			txtLName.BackColor = NameCheck(txtLName.Text) ? m_clrOK : m_clrError;
		}

		private bool NameCheck(String sName)
		{
			return Regex.IsMatch(sName, m_sNameRegExp);
		}

		private void OnZipIndexChanged(object sender, EventArgs e)
		{
			String sZip = cmbZip.SelectedItem.ToString();
			if (!String.IsNullOrEmpty(sZip))
			{
				UInt32 nZip;

				if (UInt32.TryParse(sZip, out nZip))
				{
					HashSet<String> hshCities;
					if (m_dctZipToCity.TryGetValue(nZip, out hshCities))
					{
						Color clrBkGrnd = (hshCities.Contains(txtCity.Text.Trim())) ? m_clrOK : m_clrError;
						txtCity.BackColor = clrBkGrnd;
						cmbZip.BackColor = clrBkGrnd;
					}
				}
			}
		}

		private void OnOK(object sender, EventArgs e)
		{
			decimal dGrandTotal = 0.0M;
			txtOrderTotal.Clear();

			bool bValid = ValidateContactInfo();
			if (bValid)
			{
				foreach (List<TextBox> itemOrder in m_lstOrderItems)
				{
					if (ValidateOrder(itemOrder))
					{
						decimal dCost = 0M;
						UInt32 uiQty = 0;

						if (decimal.TryParse(itemOrder[1].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out dCost) && UInt32.TryParse(itemOrder[2].Text, out uiQty))
						{
							decimal dTotal = dCost * uiQty;
							dGrandTotal += dTotal;
							itemOrder[3].Text = String.Format("{0:C}", dTotal);
						}
					}
				}

				txtOrderTotal.Text = String.Format("{0:C}", dGrandTotal);
			}
		}

		private void OnCancel(object sender, EventArgs e)
		{
			m_bCancelValidation = true;
			Close();
		}

		private bool ValidateContactInfo()
		{
			return true;
		}

		private bool ValidateOrder(List<TextBox> lstOrder)
		{
			bool bValid = false;
			bool bAllBlank = true;

			foreach(TextBox txtItem in lstOrder)
			{
				if (!String.IsNullOrWhiteSpace(txtItem.Text))
				{
					bAllBlank = false;
					break;
				}
			}

			if (!bAllBlank)
			{
				if (ValidateInput(lstOrder[0], m_sDescRegExp) &&
					ValidateInput(lstOrder[1], m_sCurrencyRegExp) &&
					ValidateInput(lstOrder[2], m_sQtyRegExp))
				{
					bValid = true;
				}
			}

			return bValid;
		}

		private void ValidateDescription(object sender, CancelEventArgs e)
		{
			if (!m_bCancelValidation)
			{
				e.Cancel = !ValidateInput(sender as TextBox, m_sDescRegExp);
			}
		}

		private void ValidateCost(object sender, System.EventArgs e)
		{
			if (!m_bCancelValidation)
			{
				TextBox txtCost = sender as TextBox;
				bool bValid = ValidateInput(txtCost, m_sCurrencyRegExp);
				if ((txtCost != null) && !String.IsNullOrWhiteSpace(txtCost.Text) && bValid)
				{
					float flCost;
					if (float.TryParse(txtCost.Text, out flCost))
						txtCost.Text = String.Format("{0:C}", flCost);
				}
			}
		}

		private void ValidateQty(object sender, CancelEventArgs e)
		{
			if (!m_bCancelValidation)
			{
				TextBox txtQty = sender as TextBox;
				e.Cancel = !ValidateInput(txtQty, m_sQtyRegExp);
			}
		}

		private bool ValidateInput(TextBox txtInput, String sRegExp)
		{
			bool bValid = (txtInput != null) && (txtInput.Text.Length > 0) && Regex.IsMatch(txtInput.Text, sRegExp);
			txtInput.BackColor = bValid ? m_clrOK : m_clrError;
			return bValid;
		}

		// ******** Private member variables ********
		List<List<TextBox>> m_lstOrderItems;

		Color m_clrError = Color.LightPink;
		Color m_clrOK = SystemColors.Control;
		bool m_bCancelValidation = false;

		String m_sNameRegExp = @"^([A-Z][a-z]*(-|'| )?)+$";
		String m_sDescRegExp = @"^(( )*[A-Z][A-Za-z\d]{2,})*$";
		String m_sCurrencyRegExp = @"^\$?(((\d{1,6}(\.\d{1,2})?)|(\d{1,3},\d{3}(\.\d{1,2})?)|\(((\d{1,6}(\.\d{1,2})?)|(\d{1,3},\d{3}(\.\d{1,2})?))\)))$";
		String m_sQtyRegExp = @"^\d+$";

		MultiValueDictionary<UInt32, String> m_dctZipToCity = new MultiValueDictionary<UInt32, String>();
	}
}
