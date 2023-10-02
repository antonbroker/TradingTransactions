using System;
using System.Drawing;
using System.Windows.Forms;
using TradingTransactions.Models;
using TradingTransactions.Models.Trades;
using ShareMap = QuoteMap.QuoteMap;

namespace TradingTransactions
{
	public partial class TradeCreateForm : Form
	{
		private BindingSource _transactions;
		private ShareMap _shareMap;
		private string _selectedTicker;
		private TradeType _selectedTradeType;
		private bool _isCosedTrade;

		public TradeCreateForm()
		{
			InitializeComponent();
		}

		private void TransactionCreateForm_Load(object sender, EventArgs e)
		{
			SelectLongTrade();
			CenterToParent();
			TradesForm transactionsForm = Owner as TradesForm;
			_transactions = transactionsForm.Transactions;
			_shareMap = transactionsForm.ShareMap;
			ShareNameComboBox.Items.AddRange(Enum.GetNames(typeof(ShareEnum)));
			//update current price by event
			_shareMap.QuoteUpdated += (args) =>
			{
				if (!_isCosedTrade && args.Symbol == _selectedTicker)
				{
					decimal newPrice = Convert.ToDecimal(args.Price);
					//update form element from other thread
					Action actionDelegate = new Action(() => CurrentOrClosePriceValue.Value = newPrice);
					CurrentOrClosePriceValue.Invoke(actionDelegate);
				}
			};
			UpdateUserInterface();
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			_transactions.Add(
				CreateTrade(
					Helper.ShareByNameDictionary[ShareNameComboBox.Text],
					OpenPriceValue.Value,
					CurrentOrClosePriceValue.Value,
					Convert.ToInt32(SharesAmountValue.Value)
				)
			);
			Close();
		}

		private void LongTradeSelectButton_Click(object sender, EventArgs e)
		{
			SelectLongTrade();
		}

		private void ShortTradeSelectButton_Click(object sender, EventArgs e)
		{
			SelectShortTrade();
		}

		private void isClosedTradeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;

			if (checkBox.Checked == true)
			{
				CurrentOrClosePriceLabel.Text = "Close price";
				CurrentOrClosePriceValue.Enabled = _isCosedTrade = true;
			}
			else
			{
				CurrentOrClosePriceLabel.Text = "Current price";
				CurrentOrClosePriceValue.Enabled = _isCosedTrade = false;
				decimal newPrice = Convert.ToDecimal((Owner as TradesForm).ShareMap.GetQuote(_selectedTicker).Price);
				CurrentOrClosePriceValue.Value = newPrice;
			}
		}

		private BaseTrade CreateTrade(ShareEnum ticker, decimal openPrice, decimal currentOrClosePrice, int sharesAmount)
		{
			return Helper.CreateTrade(
				_selectedTradeType, 
				_isCosedTrade, 
				ticker, 
				openPrice, 
				currentOrClosePrice, 
				sharesAmount);
		}

		private void SelectLongTrade()
		{
			LongTradeSelectButton.Enabled = false;
			LongTradeSelectButton.BackColor = Color.DarkSeaGreen;

			TradeTypeLabel.Text = $"Creating {LongTradeSelectButton.Text.ToLower()}";
			TradeTypeLabel.BackColor = Color.LimeGreen;

			ShortTradeSelectButton.Enabled = true;
			ShortTradeSelectButton.BackColor = Color.OrangeRed;

			_selectedTradeType = TradeType.LongTrage;
		}

		private void SelectShortTrade()
		{
			ShortTradeSelectButton.Enabled = false;
			ShortTradeSelectButton.BackColor = Color.LightCoral;

			TradeTypeLabel.Text = $"Creating {ShortTradeSelectButton.Text.ToLower()}";
			TradeTypeLabel.BackColor = Color.OrangeRed;

			LongTradeSelectButton.Enabled = true;
			LongTradeSelectButton.BackColor = Color.LimeGreen;

			_selectedTradeType = TradeType.ShortTrade;
		}


		//validation part
		private void ShareNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateUserInterface();

			_selectedTicker = Helper.TickerByNameDictionary[ShareNameComboBox.Text];
			decimal openPrice = Convert.ToDecimal(_shareMap.GetQuote(_selectedTicker).Price);
			CurrentOrClosePriceValue.Value = OpenPriceValue.Value = openPrice;
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
			CreateButton.Enabled =
				!string.IsNullOrWhiteSpace(ShareNameComboBox.Text) &&
				OpenPriceValue.Value > 0 &&
				CurrentOrClosePriceValue.Value > 0 &&
				SharesAmountValue.Value > 0;
		}
	}
}
