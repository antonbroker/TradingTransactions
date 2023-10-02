namespace TradingTransactions
{
    partial class TradesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.TradeCreateButton = new System.Windows.Forms.Button();
			this.TradeRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
			this.OpenOrClosedLabel = new System.Windows.Forms.Label();
			this.EditTradeButton = new System.Windows.Forms.Button();
			this.DeleteTradeButton = new System.Windows.Forms.Button();
			this.SharesAmountValueLabel = new System.Windows.Forms.Label();
			this.SharesAmountTextLabel = new System.Windows.Forms.Label();
			this.TradeResultLabel = new System.Windows.Forms.Label();
			this.CurrentOrClosePriceValueLabel = new System.Windows.Forms.Label();
			this.OpenPriceValueLabel = new System.Windows.Forms.Label();
			this.CloseTradeButton = new System.Windows.Forms.Button();
			this.OpenPriceTextLabel = new System.Windows.Forms.Label();
			this.ShareNameTextLabel = new System.Windows.Forms.Label();
			this.ShareNameValueLabel = new System.Windows.Forms.Label();
			this.CurrentOrClosePriceTextLabel = new System.Windows.Forms.Label();
			this.TradeTypeLabel = new System.Windows.Forms.Label();
			this.TotalResultLabel = new System.Windows.Forms.Label();
			this.TradeRepeater.ItemTemplate.SuspendLayout();
			this.TradeRepeater.SuspendLayout();
			this.SuspendLayout();
			// 
			// TradeCreateButton
			// 
			this.TradeCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TradeCreateButton.Location = new System.Drawing.Point(100, 697);
			this.TradeCreateButton.Margin = new System.Windows.Forms.Padding(2);
			this.TradeCreateButton.Name = "TradeCreateButton";
			this.TradeCreateButton.Size = new System.Drawing.Size(150, 36);
			this.TradeCreateButton.TabIndex = 0;
			this.TradeCreateButton.Text = "Create trade";
			this.TradeCreateButton.UseVisualStyleBackColor = true;
			this.TradeCreateButton.Click += new System.EventHandler(this.TradeCreateButton_Click);
			// 
			// TradeRepeater
			// 
			// 
			// TradeRepeater.ItemTemplate
			// 
			this.TradeRepeater.ItemTemplate.Controls.Add(this.OpenOrClosedLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.EditTradeButton);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.DeleteTradeButton);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.SharesAmountValueLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.SharesAmountTextLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.TradeResultLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.CurrentOrClosePriceValueLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.OpenPriceValueLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.CloseTradeButton);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.OpenPriceTextLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.ShareNameTextLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.ShareNameValueLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.CurrentOrClosePriceTextLabel);
			this.TradeRepeater.ItemTemplate.Controls.Add(this.TradeTypeLabel);
			this.TradeRepeater.ItemTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TradeRepeater.ItemTemplate.Size = new System.Drawing.Size(850, 98);
			this.TradeRepeater.ItemTemplate.DoubleClick += new System.EventHandler(this.TradeRepeater_ItemTemplate_DoubleClick);
			this.TradeRepeater.Location = new System.Drawing.Point(26, 28);
			this.TradeRepeater.Name = "TradeRepeater";
			this.TradeRepeater.Size = new System.Drawing.Size(858, 644);
			this.TradeRepeater.TabIndex = 17;
			this.TradeRepeater.Text = "dataRepeater1";
			// 
			// OpenOrClosedLabel
			// 
			this.OpenOrClosedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OpenOrClosedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenOrClosedLabel.Location = new System.Drawing.Point(11, 56);
			this.OpenOrClosedLabel.Name = "OpenOrClosedLabel";
			this.OpenOrClosedLabel.Size = new System.Drawing.Size(120, 26);
			this.OpenOrClosedLabel.TabIndex = 14;
			this.OpenOrClosedLabel.Text = "Open";
			this.OpenOrClosedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EditTradeButton
			// 
			this.EditTradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditTradeButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EditTradeButton.Location = new System.Drawing.Point(743, 6);
			this.EditTradeButton.Name = "EditTradeButton";
			this.EditTradeButton.Size = new System.Drawing.Size(33, 33);
			this.EditTradeButton.TabIndex = 13;
			this.EditTradeButton.Text = "✎";
			this.EditTradeButton.UseVisualStyleBackColor = true;
			this.EditTradeButton.Click += new System.EventHandler(this.EditTradeButton_Click);
			// 
			// DeleteTradeButton
			// 
			this.DeleteTradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteTradeButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DeleteTradeButton.Location = new System.Drawing.Point(782, 6);
			this.DeleteTradeButton.Name = "DeleteTradeButton";
			this.DeleteTradeButton.Size = new System.Drawing.Size(33, 33);
			this.DeleteTradeButton.TabIndex = 12;
			this.DeleteTradeButton.Text = "🗑";
			this.DeleteTradeButton.UseVisualStyleBackColor = true;
			this.DeleteTradeButton.Click += new System.EventHandler(this.DeleteTradeButton_Click);
			// 
			// SharesAmountValueLabel
			// 
			this.SharesAmountValueLabel.AutoSize = true;
			this.SharesAmountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SharesAmountValueLabel.Location = new System.Drawing.Point(462, 15);
			this.SharesAmountValueLabel.Name = "SharesAmountValueLabel";
			this.SharesAmountValueLabel.Size = new System.Drawing.Size(20, 24);
			this.SharesAmountValueLabel.TabIndex = 11;
			this.SharesAmountValueLabel.Text = "5";
			this.SharesAmountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SharesAmountTextLabel
			// 
			this.SharesAmountTextLabel.AutoSize = true;
			this.SharesAmountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SharesAmountTextLabel.Location = new System.Drawing.Point(385, 15);
			this.SharesAmountTextLabel.Name = "SharesAmountTextLabel";
			this.SharesAmountTextLabel.Size = new System.Drawing.Size(81, 24);
			this.SharesAmountTextLabel.TabIndex = 10;
			this.SharesAmountTextLabel.Text = "Amount:";
			this.SharesAmountTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TradeResultLabel
			// 
			this.TradeResultLabel.AutoSize = true;
			this.TradeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TradeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TradeResultLabel.Location = new System.Drawing.Point(584, 55);
			this.TradeResultLabel.Name = "TradeResultLabel";
			this.TradeResultLabel.Size = new System.Drawing.Size(143, 26);
			this.TradeResultLabel.TabIndex = 8;
			this.TradeResultLabel.Text = "Result: 1570 $";
			this.TradeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CurrentOrClosePriceValueLabel
			// 
			this.CurrentOrClosePriceValueLabel.AutoSize = true;
			this.CurrentOrClosePriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceValueLabel.Location = new System.Drawing.Point(462, 57);
			this.CurrentOrClosePriceValueLabel.Name = "CurrentOrClosePriceValueLabel";
			this.CurrentOrClosePriceValueLabel.Size = new System.Drawing.Size(65, 24);
			this.CurrentOrClosePriceValueLabel.TabIndex = 7;
			this.CurrentOrClosePriceValueLabel.Text = "1329 $";
			this.CurrentOrClosePriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OpenPriceValueLabel
			// 
			this.OpenPriceValueLabel.AutoSize = true;
			this.OpenPriceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPriceValueLabel.Location = new System.Drawing.Point(240, 58);
			this.OpenPriceValueLabel.Name = "OpenPriceValueLabel";
			this.OpenPriceValueLabel.Size = new System.Drawing.Size(65, 24);
			this.OpenPriceValueLabel.TabIndex = 6;
			this.OpenPriceValueLabel.Text = "1015 $";
			this.OpenPriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CloseTradeButton
			// 
			this.CloseTradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseTradeButton.Location = new System.Drawing.Point(584, 6);
			this.CloseTradeButton.Name = "CloseTradeButton";
			this.CloseTradeButton.Size = new System.Drawing.Size(130, 33);
			this.CloseTradeButton.TabIndex = 5;
			this.CloseTradeButton.Text = "Close trade";
			this.CloseTradeButton.UseVisualStyleBackColor = true;
			this.CloseTradeButton.Click += new System.EventHandler(this.CloseTradeButton_Click);
			// 
			// OpenPriceTextLabel
			// 
			this.OpenPriceTextLabel.AutoSize = true;
			this.OpenPriceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPriceTextLabel.Location = new System.Drawing.Point(134, 58);
			this.OpenPriceTextLabel.Name = "OpenPriceTextLabel";
			this.OpenPriceTextLabel.Size = new System.Drawing.Size(110, 24);
			this.OpenPriceTextLabel.TabIndex = 4;
			this.OpenPriceTextLabel.Text = "Open price:";
			this.OpenPriceTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ShareNameTextLabel
			// 
			this.ShareNameTextLabel.AutoSize = true;
			this.ShareNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameTextLabel.Location = new System.Drawing.Point(179, 16);
			this.ShareNameTextLabel.Name = "ShareNameTextLabel";
			this.ShareNameTextLabel.Size = new System.Drawing.Size(65, 24);
			this.ShareNameTextLabel.TabIndex = 3;
			this.ShareNameTextLabel.Text = "Share:";
			this.ShareNameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ShareNameValueLabel
			// 
			this.ShareNameValueLabel.AutoSize = true;
			this.ShareNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameValueLabel.Location = new System.Drawing.Point(240, 16);
			this.ShareNameValueLabel.Name = "ShareNameValueLabel";
			this.ShareNameValueLabel.Size = new System.Drawing.Size(60, 24);
			this.ShareNameValueLabel.TabIndex = 2;
			this.ShareNameValueLabel.Text = "Apple";
			this.ShareNameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CurrentOrClosePriceTextLabel
			// 
			this.CurrentOrClosePriceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceTextLabel.Location = new System.Drawing.Point(292, 57);
			this.CurrentOrClosePriceTextLabel.Name = "CurrentOrClosePriceTextLabel";
			this.CurrentOrClosePriceTextLabel.Size = new System.Drawing.Size(174, 24);
			this.CurrentOrClosePriceTextLabel.TabIndex = 1;
			this.CurrentOrClosePriceTextLabel.Text = "Close/current price:";
			this.CurrentOrClosePriceTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TradeTypeLabel
			// 
			this.TradeTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TradeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TradeTypeLabel.Location = new System.Drawing.Point(11, 9);
			this.TradeTypeLabel.Name = "TradeTypeLabel";
			this.TradeTypeLabel.Size = new System.Drawing.Size(120, 26);
			this.TradeTypeLabel.TabIndex = 0;
			this.TradeTypeLabel.Text = "Trade type";
			this.TradeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TotalResultLabel
			// 
			this.TotalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TotalResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TotalResultLabel.Location = new System.Drawing.Point(440, 697);
			this.TotalResultLabel.Name = "TotalResultLabel";
			this.TotalResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TotalResultLabel.Size = new System.Drawing.Size(342, 36);
			this.TotalResultLabel.TabIndex = 18;
			this.TotalResultLabel.Text = "Result: 1570 $";
			this.TotalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TradesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 754);
			this.Controls.Add(this.TotalResultLabel);
			this.Controls.Add(this.TradeRepeater);
			this.Controls.Add(this.TradeCreateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TradesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TransactionsForm";
			this.Load += new System.EventHandler(this.TransactionsForm_Load);
			this.TradeRepeater.ItemTemplate.ResumeLayout(false);
			this.TradeRepeater.ItemTemplate.PerformLayout();
			this.TradeRepeater.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TradeCreateButton;
		private Microsoft.VisualBasic.PowerPacks.DataRepeater TradeRepeater;
		private System.Windows.Forms.Label ShareNameValueLabel;
		private System.Windows.Forms.Label CurrentOrClosePriceTextLabel;
		private System.Windows.Forms.Label TradeTypeLabel;
		private System.Windows.Forms.Label ShareNameTextLabel;
		private System.Windows.Forms.Label OpenPriceTextLabel;
		private System.Windows.Forms.Button CloseTradeButton;
		private System.Windows.Forms.Label OpenPriceValueLabel;
		private System.Windows.Forms.Label CurrentOrClosePriceValueLabel;
		private System.Windows.Forms.Label TradeResultLabel;
		private System.Windows.Forms.Label SharesAmountValueLabel;
		private System.Windows.Forms.Label SharesAmountTextLabel;
		private System.Windows.Forms.Button DeleteTradeButton;
		private System.Windows.Forms.Button EditTradeButton;
		private System.Windows.Forms.Label TotalResultLabel;
		private System.Windows.Forms.Label OpenOrClosedLabel;
	}
}

