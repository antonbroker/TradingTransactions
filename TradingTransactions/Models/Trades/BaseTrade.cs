using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;

namespace TradingTransactions.Models.Trades
{
	[Serializable]
	public abstract class BaseTrade: INotifyPropertyChanged //?
	{
		// Variables:
		public ShareEnum Ticker { get; protected set; } //?
		public string ShareName => Ticker.ToString();//?
		public decimal OpenPrice { get; set; }//ok
		public int SharesAmount { get; set; }//ok
		public TradeType Type { get; protected set;  }//ok

		[field: NonSerialized]//?
		public event PropertyChangedEventHandler PropertyChanged;//?

		// Constructor:
		public BaseTrade(ShareEnum ticker, decimal openPrice, int sharesAmount)
		{
			Ticker = ticker;
			OpenPrice = openPrice;
			SharesAmount = sharesAmount;
		}

		// Methods:
		public abstract decimal GetTradeResult(); //return trade result
		public abstract void SetDataToRepeaterRow(DataRepeaterItem item);//?
		public abstract void SetDataToUpdateForm(TradeUpdateForm form);//?

		protected void NotifyPropertyChanged(string name)//?
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(name));
			}
		}
	}
}
