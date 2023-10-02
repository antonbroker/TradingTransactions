using System;
using System.Collections.Generic;
using System.Linq;
using TradingTransactions.Models.Trades;

namespace TradingTransactions.Models
{
	static class Helper
	{
		public static Dictionary<string, ShareEnum> ShareByTickerDictionary => new Dictionary<string, ShareEnum>() 
		{
			{ "NASDAQ:AAPL", ShareEnum.Apple },
			{ "NASDAQ:NVDA", ShareEnum.Nvidia },
			{ "NASDAQ:TSLA", ShareEnum.Tesla },
			{ "NYSE:BA", ShareEnum.Boeing },
			{ "NASDAQ:GOOGL", ShareEnum.Google },
			{ "MOEX:GAZP", ShareEnum.Gazprom },
			{ "MOEX:SBER", ShareEnum.Sberbank },
			{ "MOEX:YNDX", ShareEnum.Yandex },
			{ "BINANCE:BTCUSD", ShareEnum.Bitcoin },
			{ "BINANCE:ETHUSD", ShareEnum.Ethereum },
		};

		public static Dictionary<ShareEnum, string> TickerByShareDictionary =>
			ShareByTickerDictionary.ToDictionary(x => x.Value, x=> x.Key);

		public static Dictionary<string, ShareEnum> ShareByNameDictionary => 
			ShareByTickerDictionary.ToDictionary(x => Enum.GetName(typeof(ShareEnum), x.Value), x => x.Value);

		public static Dictionary<string, string> TickerByNameDictionary =>
			ShareByNameDictionary.ToDictionary(x => x.Key, x => TickerByShareDictionary[x.Value]);

		public static List<string> Tickers => ShareByTickerDictionary.Select(x => x.Key).ToList();

		public static BaseTrade CreateTrade(
			TradeType type, 
			bool isClosedTrade, 
			ShareEnum ticker, 
			decimal openPrice, 
			decimal currentOrClosePrice, 
			int sharesAmount)
		{
			switch (type)
			{
				case TradeType.LongTrage:
					{
						if (isClosedTrade)
						{
							return new LongClosedTrade(ticker, openPrice, currentOrClosePrice, sharesAmount);
						}
						else
						{
							return new LongOpenTrade(ticker, openPrice, currentOrClosePrice, sharesAmount);
						}
					};
				case TradeType.ShortTrade:
					{
						if (isClosedTrade)
						{
							return new ShortClosedTrade(ticker, openPrice, currentOrClosePrice, sharesAmount);
						}
						else
						{
							return new ShortOpenTrade(ticker, openPrice, currentOrClosePrice, sharesAmount);
						}

					};
				default: throw new Exception();
			};
		}
	}
}
