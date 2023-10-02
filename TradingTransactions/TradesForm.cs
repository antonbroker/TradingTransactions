using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingTransactions.Models;
using System.Runtime.Serialization.Formatters.Binary;
using TradingTransactions.Models.Trades;
using ShareMap = QuoteMap.QuoteMap;
using ShareModel = QuoteMap.QuoteModel;

namespace TradingTransactions
{
	public partial/*?*/ class TradesForm : Form
    {
        public BindingSource Transactions = new BindingSource();
        public ShareMap ShareMap;

        private string _transactionHistoryFilePath = Path.Combine(Directory.GetCurrentDirectory(), "userData.bin");

        public TradesForm()
        {
            InitializeComponent();
			InitializeTransactions();
            try
            {
                new Thread(BackgroundJob).Start();
            } catch (Exception ex)
			{
                Console.WriteLine("");
			}

            this.Closed += (s, args) => saveTransactions();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            UpdateTotalResultRow();

            for (int i = 0; i < Transactions.Count; i++)
            {
                UpdateDataRepeaterRow(i);
            }
        }

        private void InitializeTransactions()
        {
            Transactions.DataSource = loadTransaction();
            TradeRepeater.DataSource = Transactions;


            Transactions.ListChanged += (s, args) =>
            {
                UpdateDataRepeaterRow(args.NewIndex);
                UpdateTotalResultRow();
            };

            //binding common fields
            ShareNameValueLabel.DataBindings.Add("Text", Transactions, "Ticker");
            SharesAmountValueLabel.DataBindings.Add("Text", Transactions, "SharesAmount");
        }

		private void TradeCreateButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var transactionCreateForm = new TradeCreateForm();//var?
            transactionCreateForm.Closed += (s, args) => this.Enabled = true;
            transactionCreateForm.Show(this);
        }

        private void CloseTradeButton_Click(object sender, EventArgs e)
        {
            Transactions[TradeRepeater.CurrentItemIndex] = (Transactions.Current as BaseOpenTrade).GetClosedTrade();
        }

        private void OpenTradeUpdateForm()
		{
            this.Enabled = false;
            var openTradeUpdateForm = new TradeUpdateForm();
            openTradeUpdateForm.Closed += (s, args) => this.Enabled = true;
            openTradeUpdateForm.Show(this);

        }
        private void EditTradeButton_Click(object sender, EventArgs e)
        {
            OpenTradeUpdateForm();
        }

        private void TradeRepeater_ItemTemplate_DoubleClick(object sender, EventArgs e)
        {
            OpenTradeUpdateForm();
        }

        private void DeleteTradeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you to delete this trade?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Transactions.RemoveCurrent();
            }
        }

        private void UpdateDataRepeaterRow(int index)
		{
            if (TradeRepeater.ItemCount == index) return; //skip update during delete element

            int oldIndex = TradeRepeater.CurrentItemIndex;
            TradeRepeater.CurrentItemIndex = index;

            (Transactions[index] as BaseTrade).SetDataToRepeaterRow(TradeRepeater.CurrentItem);

            TradeRepeater.CurrentItemIndex = oldIndex;
        }

        private void UpdateTotalResultRow()
        {
            decimal totalResult = (Transactions.DataSource as TradeList).GetTotalResult();
            TotalResultLabel.BackColor = totalResult >= 0 ? Color.LimeGreen : Color.OrangeRed;
            TotalResultLabel.Text = $"Total result: {totalResult} $";
        }

        private void saveTransactions()
		{
            using (FileStream fs = new FileStream(_transactionHistoryFilePath, FileMode.Create))
            {
                new BinaryFormatter().Serialize(fs, Transactions.DataSource);
            }
        }

        private TradeList loadTransaction()
		{
            if (!File.Exists(_transactionHistoryFilePath)) 
                return new TradeList();

            using (FileStream fs = new FileStream(_transactionHistoryFilePath, FileMode.Open))
            {
               return new TradeList((new BinaryFormatter().Deserialize(fs) as TradeList)); //new list to reload the binding 
            }
        }

        //background job
        private async void BackgroundJob()
        {
            await InitializeShareMapAsync();
            ShareMap.QuoteUpdated += (evg) => Invoke((Action<ShareModel>)UpdatePriceHandler, evg);
        }
                
        private void UpdatePriceHandler(ShareModel share)
        {
            decimal newPrice = Convert.ToDecimal(share.Price);

            (Transactions.DataSource as TradeList)
                .Where(x => Helper.TickerByShareDictionary[x.Ticker] == share.Symbol && x is BaseOpenTrade)
                .Cast<BaseOpenTrade>()
                .ToList()
                .ForEach(x => {
                    x.CurrentPrice = newPrice;
                });
        }

        private async Task InitializeShareMapAsync()
        {
            ShareMap = new ShareMap();
            await ShareMap.StartSessionAsync();
            Helper.Tickers.ForEach(ticker => ShareMap.AddQuoteSync(ticker));
        }
	}
}
