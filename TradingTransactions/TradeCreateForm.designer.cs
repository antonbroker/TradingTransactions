
namespace TradingTransactions
{
	partial class TradeCreateForm
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
			this.CreateButton = new System.Windows.Forms.Button();
			this.ShareNameLabel = new System.Windows.Forms.Label();
			this.OpenPriceLabel = new System.Windows.Forms.Label();
			this.CurrentOrClosePriceLabel = new System.Windows.Forms.Label();
			this.SharesAmountLabel = new System.Windows.Forms.Label();
			this.OpenPriceValue = new System.Windows.Forms.NumericUpDown();
			this.SharesAmountValue = new System.Windows.Forms.NumericUpDown();
			this.CurrentOrClosePriceValue = new System.Windows.Forms.NumericUpDown();
			this.TradeTypeLabel = new System.Windows.Forms.Label();
			this.LongTradeSelectButton = new System.Windows.Forms.Button();
			this.ShortTradeSelectButton = new System.Windows.Forms.Button();
			this.isClosedTradeCheckBox = new System.Windows.Forms.CheckBox();
			this.ShareNameComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.OpenPriceValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SharesAmountValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentOrClosePriceValue)).BeginInit();
			this.SuspendLayout();
			// 
			// CreateButton
			// 
			this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CreateButton.Location = new System.Drawing.Point(120, 413);
			this.CreateButton.Margin = new System.Windows.Forms.Padding(2);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(272, 36);
			this.CreateButton.TabIndex = 1;
			this.CreateButton.Text = "Create";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// ShareNameLabel
			// 
			this.ShareNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameLabel.Location = new System.Drawing.Point(26, 187);
			this.ShareNameLabel.Name = "ShareNameLabel";
			this.ShareNameLabel.Size = new System.Drawing.Size(140, 29);
			this.ShareNameLabel.TabIndex = 2;
			this.ShareNameLabel.Text = "Share name";
			// 
			// OpenPriceLabel
			// 
			this.OpenPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPriceLabel.Location = new System.Drawing.Point(26, 234);
			this.OpenPriceLabel.Name = "OpenPriceLabel";
			this.OpenPriceLabel.Size = new System.Drawing.Size(140, 29);
			this.OpenPriceLabel.TabIndex = 4;
			this.OpenPriceLabel.Text = "Open price";
			// 
			// CurrentOrClosePriceLabel
			// 
			this.CurrentOrClosePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceLabel.Location = new System.Drawing.Point(26, 281);
			this.CurrentOrClosePriceLabel.Name = "CurrentOrClosePriceLabel";
			this.CurrentOrClosePriceLabel.Size = new System.Drawing.Size(140, 29);
			this.CurrentOrClosePriceLabel.TabIndex = 6;
			this.CurrentOrClosePriceLabel.Text = "Current price";
			// 
			// SharesAmountLabel
			// 
			this.SharesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SharesAmountLabel.Location = new System.Drawing.Point(26, 329);
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
			this.OpenPriceValue.Location = new System.Drawing.Point(172, 234);
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
			this.SharesAmountValue.Location = new System.Drawing.Point(172, 327);
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
			this.CurrentOrClosePriceValue.Enabled = false;
			this.CurrentOrClosePriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentOrClosePriceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.CurrentOrClosePriceValue.Location = new System.Drawing.Point(172, 279);
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
			// LongTradeSelectButton
			// 
			this.LongTradeSelectButton.BackColor = System.Drawing.Color.LimeGreen;
			this.LongTradeSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LongTradeSelectButton.Location = new System.Drawing.Point(120, 88);
			this.LongTradeSelectButton.Margin = new System.Windows.Forms.Padding(2);
			this.LongTradeSelectButton.Name = "LongTradeSelectButton";
			this.LongTradeSelectButton.Size = new System.Drawing.Size(134, 45);
			this.LongTradeSelectButton.TabIndex = 15;
			this.LongTradeSelectButton.Text = "Long trade";
			this.LongTradeSelectButton.UseVisualStyleBackColor = false;
			this.LongTradeSelectButton.Click += new System.EventHandler(this.LongTradeSelectButton_Click);
			// 
			// ShortTradeSelectButton
			// 
			this.ShortTradeSelectButton.BackColor = System.Drawing.Color.OrangeRed;
			this.ShortTradeSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShortTradeSelectButton.Location = new System.Drawing.Point(258, 88);
			this.ShortTradeSelectButton.Margin = new System.Windows.Forms.Padding(2);
			this.ShortTradeSelectButton.Name = "ShortTradeSelectButton";
			this.ShortTradeSelectButton.Size = new System.Drawing.Size(134, 45);
			this.ShortTradeSelectButton.TabIndex = 16;
			this.ShortTradeSelectButton.Text = "Short trade";
			this.ShortTradeSelectButton.UseVisualStyleBackColor = false;
			this.ShortTradeSelectButton.Click += new System.EventHandler(this.ShortTradeSelectButton_Click);
			// 
			// isClosedTradeCheckBox
			// 
			this.isClosedTradeCheckBox.AutoSize = true;
			this.isClosedTradeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isClosedTradeCheckBox.Location = new System.Drawing.Point(345, 279);
			this.isClosedTradeCheckBox.Name = "isClosedTradeCheckBox";
			this.isClosedTradeCheckBox.Size = new System.Drawing.Size(132, 28);
			this.isClosedTradeCheckBox.TabIndex = 17;
			this.isClosedTradeCheckBox.Text = "closed trade";
			this.isClosedTradeCheckBox.UseVisualStyleBackColor = true;
			this.isClosedTradeCheckBox.CheckedChanged += new System.EventHandler(this.isClosedTradeCheckBox_CheckedChanged);
			// 
			// ShareNameComboBox
			// 
			this.ShareNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ShareNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShareNameComboBox.FormattingEnabled = true;
			this.ShareNameComboBox.Location = new System.Drawing.Point(173, 187);
			this.ShareNameComboBox.Name = "ShareNameComboBox";
			this.ShareNameComboBox.Size = new System.Drawing.Size(149, 32);
			this.ShareNameComboBox.TabIndex = 18;
			this.ShareNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ShareNameComboBox_SelectedIndexChanged);
			// 
			// TradeCreateForm
			// 
			this.ClientSize = new System.Drawing.Size(509, 487);
			this.Controls.Add(this.ShareNameComboBox);
			this.Controls.Add(this.isClosedTradeCheckBox);
			this.Controls.Add(this.ShortTradeSelectButton);
			this.Controls.Add(this.LongTradeSelectButton);
			this.Controls.Add(this.TradeTypeLabel);
			this.Controls.Add(this.CurrentOrClosePriceValue);
			this.Controls.Add(this.SharesAmountValue);
			this.Controls.Add(this.OpenPriceValue);
			this.Controls.Add(this.SharesAmountLabel);
			this.Controls.Add(this.CurrentOrClosePriceLabel);
			this.Controls.Add(this.OpenPriceLabel);
			this.Controls.Add(this.ShareNameLabel);
			this.Controls.Add(this.CreateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "TradeCreateForm";
			this.Text = "Create trade";
			this.Load += new System.EventHandler(this.TransactionCreateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.OpenPriceValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SharesAmountValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentOrClosePriceValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.Label ShareNameLabel;
		private System.Windows.Forms.Label OpenPriceLabel;
		private System.Windows.Forms.Label CurrentOrClosePriceLabel;
		private System.Windows.Forms.Label SharesAmountLabel;
		private System.Windows.Forms.NumericUpDown OpenPriceValue;
		private System.Windows.Forms.NumericUpDown SharesAmountValue;
		private System.Windows.Forms.NumericUpDown CurrentOrClosePriceValue;
		private System.Windows.Forms.Label TradeTypeLabel;
		private System.Windows.Forms.Button LongTradeSelectButton;
		private System.Windows.Forms.Button ShortTradeSelectButton;
		private System.Windows.Forms.CheckBox isClosedTradeCheckBox;
		private System.Windows.Forms.ComboBox ShareNameComboBox;
	}
}