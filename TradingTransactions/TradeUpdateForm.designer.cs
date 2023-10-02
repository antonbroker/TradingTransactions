
namespace TradingTransactions
{
	partial class TradeUpdateForm
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
			this.UpdateButton = new System.Windows.Forms.Button();
			this.ShareNameLabel = new System.Windows.Forms.Label();
			this.ShareNameTextBox = new System.Windows.Forms.TextBox();
			this.OpenPriceLabel = new System.Windows.Forms.Label();
			this.CurrentOrClosePriceLabel = new System.Windows.Forms.Label();
			this.SharesAmountLabel = new System.Windows.Forms.Label();
			this.OpenPriceValue = new System.Windows.Forms.NumericUpDown();
			this.SharesAmountValue = new System.Windows.Forms.NumericUpDown();
			this.CurrentOrClosePriceValue = new System.Windows.Forms.NumericUpDown();
			this.TradeTypeLabel = new System.Windows.Forms.Label();
			this.isClosedTradeCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.OpenPriceValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SharesAmountValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentOrClosePriceValue)).BeginInit();
			this.SuspendLayout();
			// 
			// UpdateButton
			// 
			this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UpdateButton.Location = new System.Drawing.Point(120, 341);
			this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(272, 36);
			this.UpdateButton.TabIndex = 1;
			this.UpdateButton.Text = "Save";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// ShareNameLabel
			// 
			this.ShareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameLabel.Location = new System.Drawing.Point(26, 115);
			this.ShareNameLabel.Name = "ShareNameLabel";
			this.ShareNameLabel.Size = new System.Drawing.Size(140, 29);
			this.ShareNameLabel.TabIndex = 2;
			this.ShareNameLabel.Text = "Share name";
			// 
			// ShareNameTextBox
			// 
			this.ShareNameTextBox.Enabled = false;
			this.ShareNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameTextBox.Location = new System.Drawing.Point(172, 115);
			this.ShareNameTextBox.Name = "ShareNameTextBox";
			this.ShareNameTextBox.Size = new System.Drawing.Size(150, 29);
			this.ShareNameTextBox.TabIndex = 3;
			// 
			// OpenPriceLabel
			// 
			this.OpenPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPriceLabel.Location = new System.Drawing.Point(26, 162);
			this.OpenPriceLabel.Name = "OpenPriceLabel";
			this.OpenPriceLabel.Size = new System.Drawing.Size(140, 29);
			this.OpenPriceLabel.TabIndex = 4;
			this.OpenPriceLabel.Text = "Open price";
			// 
			// CurrentOrClosePriceLabel
			// 
			this.CurrentOrClosePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceLabel.Location = new System.Drawing.Point(26, 209);
			this.CurrentOrClosePriceLabel.Name = "CurrentOrClosePriceLabel";
			this.CurrentOrClosePriceLabel.Size = new System.Drawing.Size(140, 29);
			this.CurrentOrClosePriceLabel.TabIndex = 6;
			this.CurrentOrClosePriceLabel.Text = "Current price";
			// 
			// SharesAmountLabel
			// 
			this.SharesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SharesAmountLabel.Location = new System.Drawing.Point(26, 257);
			this.SharesAmountLabel.Name = "SharesAmountLabel";
			this.SharesAmountLabel.Size = new System.Drawing.Size(140, 29);
			this.SharesAmountLabel.TabIndex = 8;
			this.SharesAmountLabel.Text = "Shares amount";
			// 
			// OpenPriceValue
			// 
			this.OpenPriceValue.DecimalPlaces = 2;
			this.OpenPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPriceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.OpenPriceValue.Location = new System.Drawing.Point(172, 162);
			this.OpenPriceValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.OpenPriceValue.Name = "OpenPriceValue";
			this.OpenPriceValue.Size = new System.Drawing.Size(150, 29);
			this.OpenPriceValue.TabIndex = 9;
			this.OpenPriceValue.ValueChanged += new System.EventHandler(this.OpenPriceValue_ValueChanged);
			// 
			// SharesAmountValue
			// 
			this.SharesAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SharesAmountValue.Location = new System.Drawing.Point(172, 255);
			this.SharesAmountValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.SharesAmountValue.Name = "SharesAmountValue";
			this.SharesAmountValue.Size = new System.Drawing.Size(150, 29);
			this.SharesAmountValue.TabIndex = 11;
			this.SharesAmountValue.ValueChanged += new System.EventHandler(this.SharesAmountValue_ValueChanged);
			// 
			// CurrentOrClosePriceValue
			// 
			this.CurrentOrClosePriceValue.DecimalPlaces = 2;
			this.CurrentOrClosePriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.CurrentOrClosePriceValue.Location = new System.Drawing.Point(172, 207);
			this.CurrentOrClosePriceValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.CurrentOrClosePriceValue.Name = "CurrentOrClosePriceValue";
			this.CurrentOrClosePriceValue.Size = new System.Drawing.Size(150, 29);
			this.CurrentOrClosePriceValue.TabIndex = 12;
			this.CurrentOrClosePriceValue.ValueChanged += new System.EventHandler(this.CurrentOrClosePriceValue_ValueChanged);
			// 
			// TradeTypeLabel
			// 
			this.TradeTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TradeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TradeTypeLabel.Location = new System.Drawing.Point(108, 26);
			this.TradeTypeLabel.Name = "TradeTypeLabel";
			this.TradeTypeLabel.Size = new System.Drawing.Size(298, 51);
			this.TradeTypeLabel.TabIndex = 14;
			this.TradeTypeLabel.Text = "Trade type";
			this.TradeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// isClosedTradeCheckBox
			// 
			this.isClosedTradeCheckBox.AutoSize = true;
			this.isClosedTradeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isClosedTradeCheckBox.Location = new System.Drawing.Point(345, 209);
			this.isClosedTradeCheckBox.Name = "isClosedTradeCheckBox";
			this.isClosedTradeCheckBox.Size = new System.Drawing.Size(132, 28);
			this.isClosedTradeCheckBox.TabIndex = 18;
			this.isClosedTradeCheckBox.Text = "closed trade";
			this.isClosedTradeCheckBox.UseVisualStyleBackColor = true;
			this.isClosedTradeCheckBox.CheckedChanged += new System.EventHandler(this.isClosedTradeCheckBox_CheckedChanged);
			// 
			// TradeUpdateForm
			// 
			this.ClientSize = new System.Drawing.Size(509, 402);
			this.Controls.Add(this.isClosedTradeCheckBox);
			this.Controls.Add(this.TradeTypeLabel);
			this.Controls.Add(this.CurrentOrClosePriceValue);
			this.Controls.Add(this.SharesAmountValue);
			this.Controls.Add(this.OpenPriceValue);
			this.Controls.Add(this.SharesAmountLabel);
			this.Controls.Add(this.CurrentOrClosePriceLabel);
			this.Controls.Add(this.OpenPriceLabel);
			this.Controls.Add(this.ShareNameTextBox);
			this.Controls.Add(this.ShareNameLabel);
			this.Controls.Add(this.UpdateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "TradeUpdateForm";
			this.Text = "Edit trade";
			this.Load += new System.EventHandler(this.TransactionCreateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.OpenPriceValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SharesAmountValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentOrClosePriceValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Label ShareNameLabel;
		private System.Windows.Forms.TextBox ShareNameTextBox;
		private System.Windows.Forms.Label OpenPriceLabel;
		private System.Windows.Forms.Label CurrentOrClosePriceLabel;
		private System.Windows.Forms.Label SharesAmountLabel;
		private System.Windows.Forms.NumericUpDown OpenPriceValue;
		private System.Windows.Forms.NumericUpDown SharesAmountValue;
		private System.Windows.Forms.NumericUpDown CurrentOrClosePriceValue;
		private System.Windows.Forms.Label TradeTypeLabel;
		private System.Windows.Forms.CheckBox isClosedTradeCheckBox;
	}
}