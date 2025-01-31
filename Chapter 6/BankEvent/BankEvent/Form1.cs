using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankEvent
{
	public partial class BankAcctForm : Form
	{
		List<BankAccount> m_lstAccounts;

		public BankAcctForm()
		{
			InitializeComponent();
		}

		private void OnFormLoad(Object sender, EventArgs e)
		{
			radioDeposit.Checked = true;
			DepositOrWithdraw(true);
			LoadAccounts();
			m_lstAccounts.Sort();
			DisplayAccounts();
		}

		private void OnDepositChecked(Object sender, EventArgs e)
		{
			DepositOrWithdraw(true);
		}

		private void OnWithdrawChecked(Object sender, EventArgs e)
		{
			DepositOrWithdraw(false);
		}

		private void DepositOrWithdraw(bool bDeposit)
		{
			if (bDeposit)
			{
				grpDeposit.Text = "Deposit";
				lblAmount.Text = "Deposit Amount";
				btnDeposit.Text = "&Make Deposit";
			}
			else
			{
				grpDeposit.Text = "Withdraw";
				lblAmount.Text = "Withdrawal Amount";
				btnDeposit.Text = "&Make Withdrawal";
			}
		}

		private void LoadAccounts()
		{
			m_lstAccounts = new List<BankAccount>(25);
			m_lstAccounts.Add(new BankAccount("Jeff", "Armstrong", 7000M));
			m_lstAccounts.Add(new BankAccount("Stella", "Armstrong", 17000M));
			m_lstAccounts.Add(new BankAccount("Adrian", "Armstrong", 7000M));
			m_lstAccounts.Add(new BankAccount("Donald", "Trump", 7000000M));
			m_lstAccounts.Add(new MoneyMarketAcct("Bill", "Gates", 90000000000M, 100M));

			foreach (BankAccount acctItem in m_lstAccounts)
			{
				acctItem.OverdrawnEvent += AcctOverdrawnEvent;
				acctItem.DepositEvent += AcctDepositEvent;
			}
		}

		private void AcctDepositEvent(Object sender, BankAccount.DepositEventArgs acctArgs)
		{
			BankAccount acctDeposit = sender as BankAccount;
			if (acctDeposit != null)
			{
				String szError = String.Format("Unable to deposit {0:C} into account for owner {1}", acctArgs.m_dcDepositAmount, acctDeposit.OwnerName);
				MessageBox.Show(szError, "Deposit Error", MessageBoxButtons.OK);
			}
		}

		private void AcctOverdrawnEvent(Object sender, BankAccount.OverdrawnEventArgs acctArgs)
		{
			BankAccount acctWithdraw = sender as BankAccount;
			if (acctWithdraw != null)
			{
				String szError = String.Format("Withdrawal amount of {0:C} exceeds available balance of {1:C} for owner {2}", acctArgs.m_dcWithdrawalAmount, acctArgs.m_dcBalance, acctWithdraw.OwnerName);
				MessageBox.Show(szError, "Withdrawal Error", MessageBoxButtons.OK);
			}
		}

		private void DisplayAccounts()
		{
			comboAccounts.Items.Clear();

			foreach(BankAccount acctItem in m_lstAccounts)
			{
				comboAccounts.Items.Add(acctItem);
			}

			if (comboAccounts.Items.Count > 0)
			{
				comboAccounts.SelectedIndex = 0;
				ShowAccountInfo(comboAccounts.SelectedItem as BankAccount);
			}
		}

		private void OnSelectedAccountChanged(Object sender, EventArgs e)
		{
			BankAccount acctSel = comboAccounts.SelectedItem as BankAccount;
			if (acctSel != null)
				ShowAccountInfo(acctSel);
		}

		private void ShowAccountInfo(BankAccount acctActive)
		{
			txtDeposit.Clear();
			txtAcctBalance.Text = String.Format("{0:C}", acctActive.Balance);
		}

		private void OnDepositOrWithdraw(Object sender, EventArgs e)
		{
			BankAccount acctSel = comboAccounts.SelectedItem as BankAccount;
			if (acctSel != null)
			{
				decimal decAmount;
				if (Decimal.TryParse(txtDeposit.Text, out decAmount))
				{
					decimal decResult = (radioDeposit.Checked) ? acctSel.MakeDeposit(decAmount) : acctSel.MakeWithdrawal(decAmount);
					ShowAccountInfo(acctSel);
				}
			}
		}
	}
}
