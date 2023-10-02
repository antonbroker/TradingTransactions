using System;
using System.Windows.Forms;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	public abstract class BaseClosedTrade : BaseTrade
	{
		public decimal ClosePrice { get; set; }//ok

		public BaseClosedTrade(ShareEnum ticker, decimal openPrice, decimal closePrice, int sharesAmount) 
			: base(ticker, openPrice, sharesAmount)
		{
			ClosePrice = closePrice;
		}

		public override void SetDataToUpdateForm(TradeUpdateForm form)//?
		{
			(form.Controls["isClosedTradeCheckBox"] as CheckBox).Checked = true;

			Label closePriceLabel = form.Controls["CurrentOrClosePriceLabel"] as Label;
			closePriceLabel.Text = "Current price:";

			NumericUpDown closePriceValue = form.Controls["CurrentOrClosePriceValue"] as NumericUpDown;
			closePriceValue.Value = ClosePrice;
		}
	}
}
