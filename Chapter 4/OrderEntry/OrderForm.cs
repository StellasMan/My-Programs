using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OrderEntry
{
	public partial class OrderForm : Form
	{
		// LinkedList m_llIst1 = new LinkedList<>

		public OrderForm()
		{
			InitializeComponent();

			// Set the accept button of the form to button1.
			AcceptButton = btnOK;

			// Set the cancel button of the form to button2.
			CancelButton = btnClear;

			// Set the start position of the form to the center of the screen.
			StartPosition = FormStartPosition.CenterScreen;

			Ellipse elShape = new Ellipse(new RectangleF(new PointF(1.0f, 1.0f), new SizeF(-1.0f, -1.0f)));
			// RectangleF rctRect = elShape.Bounds;
			IShape iTest = elShape;
			RectangleF rctRect = iTest.Bounds;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (ValidateInput())
				CalcTotals();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearEntries();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private bool ValidateInput()
		{
			TextBox txtError = null;
			bool bRetVal = true;
			foreach (LinkedList<object> row in m_listRowData)
			{
				if (!IsRowEmpty(row) && !ValidateRow(row))
				{
					bRetVal = false;
					break;
				}
			}

			if (bRetVal)
			{
				if (txtTaxRate.Text != String.Empty)
				{
					float flValue = 0;
					if (!float.TryParse(txtTaxRate.Text, out flValue))
					{
						txtError = txtTaxRate;
						bRetVal = false;
					}
				}
			}

			FocusError(txtError);

			return bRetVal;
		}

		private bool IsRowEmpty(LinkedList<object> llListObjects)
		{
			bool bRetVal = true;

			foreach (object rowItem in llListObjects)
			{
				TextBox txtItem = rowItem as TextBox;
				if (txtItem.ReadOnly != false)
				{
					txtItem.BackColor = SystemColors.ButtonHighlight;
					if (txtItem.Text != String.Empty)
					{
						bRetVal = false;
						break;
					}
				}
			}

			return bRetVal;
		}

		private void FocusError(TextBox txtErr)
		{
			if (txtErr != null)
			{
				txtErr.BackColor = Color.LightPink;
				txtErr.Focus();
			}
		}

		private bool ValidateRow(LinkedList<object> llListObjects)
		{
			bool bRetVal = true;
			int nCol = 0;
			TextBox txtError = null;

			foreach (object rowItem in llListObjects)
			{
				TextBox tboxItem = rowItem as TextBox;
				Debug.Assert(tboxItem != null);
				if (nCol == 0)
				{
					tboxItem.BackColor = SystemColors.ButtonHighlight;
					if (tboxItem.Text == String.Empty)
					{
						txtError = tboxItem;
						bRetVal = false;
						break;
					}
				}
				else if ((nCol == 1) || (nCol == 2))
				{
					tboxItem.BackColor = SystemColors.ButtonHighlight;
					float flValue = 0.0f;
					if ((tboxItem.Text != String.Empty) && !float.TryParse(tboxItem.Text, out flValue))
					{
						txtError = tboxItem;
						bRetVal = false;
						break;
					}
				}

				nCol++;
			}

			FocusError(txtError);

			return bRetVal;
		}

		private void ClearEntries()
		{
			foreach(LinkedList<object> row in m_listRowData)
			{
				foreach(object rowItem in row)
				{
					TextBox txtItem = rowItem as TextBox;
					Debug.Assert(txtItem != null);
					if (txtItem != null)
						txtItem.Text = string.Empty;
				}
			}

			txtTaxRate.Text = string.Empty;
		}

		private bool CalcTotals()
		{
			bool bRetVal = true;
			foreach (LinkedList<object> row in m_listRowData)
			{
				int nCol = 0;
				float flGrandTotal = 0.0f;
				float flQty = 0.0f;
				float flPriceEach = 0.0f;
				float flTotal = 0.0f;

				foreach (object rowItem in row)
				{
					float flValue = 0.0f;
					TextBox txtItem = rowItem as TextBox;
					switch(nCol)
					{
						case 0:
							break;

						case 1:
							if (float.TryParse(txtItem.Text, out flValue))
								flQty = flValue;
							break;

						case 2:
							if (float.TryParse(txtItem.Text, out flValue))
							{
								flPriceEach = flValue;
								flTotal = flQty * flPriceEach;
								flGrandTotal += flTotal;
							}
							break;

						case 3:
							txtItem.Text = string.Format("{0:C}", flTotal);
							txtItem.ReadOnly = true;
							break;

						default:
							Debug.Assert(false);
							break;
					}

					nCol++;
				}
			}

			return bRetVal;
		}

		private void OrderForm_Load(object sender, EventArgs e)
		{
			m_llRow1.AddLast(txtDescription1);
			m_llRow1.AddLast(txtQuantity1);
			m_llRow1.AddLast(txtPrice1);
			m_llRow1.AddLast(txtTotal1);
			m_listRowData.Add(m_llRow1);

			m_llRow2.AddLast(txtDescription2);
			m_llRow2.AddLast(txtQuantity2);
			m_llRow2.AddLast(txtPrice2);
			m_llRow2.AddLast(txtTotal2);
			m_listRowData.Add(m_llRow2);

			m_llRow3.AddLast(txtDescription3);
			m_llRow3.AddLast(txtQuantity3);
			m_llRow3.AddLast(txtPrice3);
			m_llRow3.AddLast(txtTotal3);
			m_listRowData.Add(m_llRow3);

			m_llRow4.AddLast(txtDescription4);
			m_llRow4.AddLast(txtQuantity4);
			m_llRow4.AddLast(txtPrice4);
			m_llRow4.AddLast(txtTotal4);
			m_listRowData.Add(m_llRow4);
		}
	}
}
