using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	public class LongClosedTrade: BaseClosedTrade
	{
		// Constructor:
		public LongClosedTrade(ShareEnum ticker, decimal openPrice, decimal closePrice, int sharesAmount) 
			: base(ticker, openPrice, closePrice, sharesAmount)
		{
			Type = TradeType.LongTrage;//?
		}

		// Methods:
		public override decimal GetTradeResult()
		{
			return (ClosePrice - OpenPrice) * SharesAmount;
		}

		public override void SetDataToRepeaterRow(DataRepeaterItem item)//???
		{
			Label tradeTypeLabel = item.Controls["TradeTypeLabel"] as Label;
			tradeTypeLabel.BackColor = Color.LimeGreen;
			tradeTypeLabel.Text = "Long trade";

			Label closedLabel = item.Controls["OpenOrClosedLabel"] as Label;
			closedLabel.Text = "Closed";

			Label openPriceValueLabel = item.Controls["OpenPriceValueLabel"] as Label;
			openPriceValueLabel.Text = $"{OpenPrice} $";

			Label closePriceTextLabel = item.Controls["CurrentOrClosePriceTextLabel"] as Label;
			closePriceTextLabel.Text = "Close price:";

			Label closePriceValueLabel = item.Controls["CurrentOrClosePriceValueLabel"] as Label;
			closePriceValueLabel.Text = $"{ClosePrice} $";

			decimal result = GetTradeResult();
			Label tradeResultLabel = item.Controls["TradeResultLabel"] as Label;
			tradeResultLabel.BackColor = result >= 0 ? Color.LimeGreen : Color.OrangeRed;
			tradeResultLabel.Text = $"Result: {result} $";

			Button closeTradeButton = item.Controls["CloseTradeButton"] as Button;
			closeTradeButton.Visible = false;
		}
	}
}
