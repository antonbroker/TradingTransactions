using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	class ShortClosedTrade: BaseClosedTrade
	{
		public ShortClosedTrade(ShareEnum ticker, decimal openPrice, decimal closePrice, int sharesAmount)
			: base(ticker, openPrice, closePrice, sharesAmount)
		{
			Type = TradeType.ShortTrade;
		}

		public override decimal GetTradeResult()
		{
			return (OpenPrice - ClosePrice) * SharesAmount;
		}

		public override void SetDataToRepeaterRow(DataRepeaterItem item)
		{
			Label tradeTypeLabel = item.Controls["TradeTypeLabel"] as Label;
			tradeTypeLabel.BackColor = Color.OrangeRed;
			tradeTypeLabel.Text = "Short trade";

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
