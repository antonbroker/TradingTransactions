using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TradingTransactions.Models.Trades;

namespace TradingTransactions.Models
{
	[Serializable]
	public class TradeList : BindingList<BaseTrade>//?????????
	{
		public TradeList(): base()
		{}

		public TradeList(IList<BaseTrade> list) : base(list)
		{}

		public decimal GetTotalResult()
		{
			return this.Sum(trade => trade.GetTradeResult());
		}
	}
}
