using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	public abstract class BaseOpenTrade : BaseTrade
	{
		// Variable:
		private decimal _currentPrice;

		public decimal CurrentPrice
		{
			get
			{
				return _currentPrice;
			}
			set
			{
				_currentPrice = value;// откуда value?
				NotifyPropertyChanged("CurrentPrice"); //notify about preperty changed//?
			}
		}

		// Constructor
		public BaseOpenTrade(ShareEnum ticker, decimal openPrice, decimal currentPrice, int sharesAmount)
			: base(ticker, openPrice, sharesAmount)// base?
		{
			CurrentPrice = currentPrice;
		}

		// Methods:
		public abstract BaseClosedTrade GetClosedTrade(); //return LongClosedTrade

		public override void SetDataToUpdateForm(TradeUpdateForm form)//?
		{
			(form.Controls["isClosedTradeCheckBox"] as CheckBox).Checked = false;

			Label currentPriceLabel = form.Controls["CurrentOrClosePriceLabel"] as Label;
			currentPriceLabel.Text = "Current price:";

			NumericUpDown currentPriceValue = form.Controls["CurrentOrClosePriceValue"] as NumericUpDown;
			currentPriceValue.Value = CurrentPrice;
			currentPriceValue.Enabled = false;

			//update current price by event on update trade form
			PropertyChanged += (s, args) =>
			{
				if (!form.IsCosedTrade && args.PropertyName == "CurrentPrice")
				{
					currentPriceValue.Value = CurrentPrice;
				}
			};
		}
	}
}
