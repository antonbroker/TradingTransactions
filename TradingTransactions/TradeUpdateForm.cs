using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Windows.Forms;
using TradingTransactions.Models;
using TradingTransactions.Models.Trades;

namespace TradingTransactions
{
	public partial class TradeUpdateForm : Form
	{
		private BindingSource _transactions;
		private BaseTrade _trade;
		public bool IsCosedTrade;

		public TradeUpdateForm()
		{
			InitializeComponent();
		}

		private void TransactionCreateForm_Load(object sender, EventArgs e)
		{
			CenterToParent();
			TradesForm transactionsForm = Owner as TradesForm;
			_transactions = transactionsForm.Transactions;
			_trade = (_transactions.Current as BaseTrade);

			InitializeFormValues();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			int currentIndex = (Owner.Controls["TradeRepeater"] as DataRepeater).CurrentItemIndex;
			_transactions[currentIndex] = CreateTrade(
				OpenPriceValue.Value, 
				CurrentOrClosePriceValue.Value,
				Convert.ToInt32(SharesAmountValue.Value));
			Close();
		}

		private BaseTrade CreateTrade(decimal openPrice, decimal currentOrClosePrice, int sharesAmount)
		{
			return Helper.CreateTrade(
				_trade.Type,
				IsCosedTrade,
				_trade.Ticker,
				openPrice,
				currentOrClosePrice,
				sharesAmount);
		}

		private void InitializeFormValues()
		{
			ShareNameTextBox.Text = _trade.ShareName;
			OpenPriceValue.Value = _trade.OpenPrice;
			SharesAmountValue.Value = _trade.SharesAmount;

			if (_trade.Type == TradeType.LongTrage)
			{
				TradeTypeLabel.Text = "Editing long trade";
				TradeTypeLabel.BackColor = Color.LimeGreen;
			}
			else
			{
				TradeTypeLabel.Text = "Editing short trade";
				TradeTypeLabel.BackColor = Color.OrangeRed;
			}

			_trade.SetDataToUpdateForm(this);
		}

		private void isClosedTradeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;

			if (checkBox.Checked == true)
			{
				CurrentOrClosePriceLabel.Text = "Close price";
				CurrentOrClosePriceValue.Enabled = IsCosedTrade = true;
			}
			else
			{
				CurrentOrClosePriceLabel.Text = "Current price";
				CurrentOrClosePriceValue.Enabled = IsCosedTrade = false;
				decimal newPrice = Convert.ToDecimal(
					(Owner as TradesForm).ShareMap.GetQuote(Helper.TickerByShareDictionary[_trade.Ticker]).Price);
				CurrentOrClosePriceValue.Value = newPrice;
			}
		}

		//validation part
		private void ShareNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUserInterface();
		}

		private void OpenPriceValue_ValueChanged(object sender, EventArgs e)
		{
			UpdateUserInterface();
		}

		private void CurrentOrClosePriceValue_ValueChanged(object sender, EventArgs e)
		{
			UpdateUserInterface();
		}

		private void SharesAmountValue_ValueChanged(object sender, EventArgs e)
		{
			UpdateUserInterface();
		}


		private void UpdateUserInterface()
		{
			UpdateButton.Enabled =
				!string.IsNullOrWhiteSpace(SharesAmountLabel.Text) &&
				OpenPriceValue.Value > 0 &&
				CurrentOrClosePriceValue.Value > 0 &&
				SharesAmountValue.Value > 0;
		}
	}
}
