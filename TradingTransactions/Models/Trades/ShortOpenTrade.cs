using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	public class ShortOpenTrade : BaseOpenTrade
	{
		public ShortOpenTrade(ShareEnum ticker, decimal openPrice, decimal currentPrice, int sharesAmount)
			: base(ticker, openPrice, currentPrice, sharesAmount)
		{
			Type = TradeType.ShortTrade;
		}

		public override decimal GetTradeResult()
		{
			return (OpenPrice - CurrentPrice) * SharesAmount;
		}

		public override BaseClosedTrade GetClosedTrade()
		{
			return new ShortClosedTrade(Ticker, OpenPrice, CurrentPrice, SharesAmount);
		}

		public override void SetDataToRepeaterRow(DataRepeaterItem item)
		{
			Label tradeTypeLabel = item.Controls["TradeTypeLabel"] as Label;
			tradeTypeLabel.BackColor = Color.OrangeRed;
			tradeTypeLabel.Text = "Short trade";

			Label openLabel = item.Controls["OpenOrClosedLabel"] as Label;
			openLabel.Text = "Open";

			Label openPriceValueLabel = item.Controls["OpenPriceValueLabel"] as Label;
			openPriceValueLabel.Text = $"{OpenPrice} $";

			Label currentPriceTextLabel = item.Controls["CurrentOrClosePriceTextLabel"] as Label;
			currentPriceTextLabel.Text = "Current price:";

			Label currentPriceValueLabel = item.Controls["CurrentOrClosePriceValueLabel"] as Label;
			currentPriceValueLabel.Text = $"{CurrentPrice} $";

			decimal result = GetTradeResult();

			Label tradeResultLabel = item.Controls["TradeResultLabel"] as Label;
			tradeResultLabel.BackColor = result >= 0 ? Color.LimeGreen : Color.OrangeRed;
			tradeResultLabel.Text = $"Result: {result} $";

			Button closeTradeButton = item.Controls["CloseTradeButton"] as Button;
			closeTradeButton.Visible = true;
		}
	}
}
