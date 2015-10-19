namespace My_Bittrex_2.Views
{
    partial class MainView
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMarket = new System.Windows.Forms.Label();
            this.DgCurrency = new System.Windows.Forms.DataGridView();
            this.MarketCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketCurrencyLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgAccount = new System.Windows.Forms.DataGridView();
            this.LblAccountOverview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMarket
            // 
            this.LblMarket.AutoSize = true;
            this.LblMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarket.Location = new System.Drawing.Point(150, 13);
            this.LblMarket.Name = "LblMarket";
            this.LblMarket.Size = new System.Drawing.Size(119, 17);
            this.LblMarket.TabIndex = 0;
            this.LblMarket.Text = "Available Markets";
            // 
            // DgCurrency
            // 
            this.DgCurrency.AllowUserToAddRows = false;
            this.DgCurrency.AllowUserToDeleteRows = false;
            this.DgCurrency.AllowUserToOrderColumns = true;
            this.DgCurrency.AllowUserToResizeRows = false;
            this.DgCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgCurrency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarketCurrency,
            this.MarketCurrencyLong,
            this.MarketName});
            this.DgCurrency.Location = new System.Drawing.Point(2, 42);
            this.DgCurrency.MultiSelect = false;
            this.DgCurrency.Name = "DgCurrency";
            this.DgCurrency.ReadOnly = true;
            this.DgCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCurrency.ShowEditingIcon = false;
            this.DgCurrency.ShowRowErrors = false;
            this.DgCurrency.Size = new System.Drawing.Size(414, 775);
            this.DgCurrency.TabIndex = 1;
            // 
            // MarketCurrency
            // 
            this.MarketCurrency.DataPropertyName = "MarketCurrency";
            this.MarketCurrency.HeaderText = "Currency";
            this.MarketCurrency.Name = "MarketCurrency";
            this.MarketCurrency.ReadOnly = true;
            // 
            // MarketCurrencyLong
            // 
            this.MarketCurrencyLong.DataPropertyName = "MarketCurrencyLong";
            this.MarketCurrencyLong.HeaderText = "Currency Name";
            this.MarketCurrencyLong.Name = "MarketCurrencyLong";
            this.MarketCurrencyLong.ReadOnly = true;
            // 
            // MarketName
            // 
            this.MarketName.DataPropertyName = "MarketName";
            this.MarketName.HeaderText = "MarketName";
            this.MarketName.Name = "MarketName";
            this.MarketName.ReadOnly = true;
            // 
            // DgAccount
            // 
            this.DgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAccount.Location = new System.Drawing.Point(445, 42);
            this.DgAccount.Name = "DgAccount";
            this.DgAccount.Size = new System.Drawing.Size(1110, 775);
            this.DgAccount.TabIndex = 2;
            // 
            // LblAccountOverview
            // 
            this.LblAccountOverview.AutoSize = true;
            this.LblAccountOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountOverview.Location = new System.Drawing.Point(941, 13);
            this.LblAccountOverview.Name = "LblAccountOverview";
            this.LblAccountOverview.Size = new System.Drawing.Size(121, 17);
            this.LblAccountOverview.TabIndex = 4;
            this.LblAccountOverview.Text = "Account Overview";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblAccountOverview);
            this.Controls.Add(this.DgAccount);
            this.Controls.Add(this.DgCurrency);
            this.Controls.Add(this.LblMarket);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1558, 820);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMarket;
        private System.Windows.Forms.DataGridView DgCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketCurrencyLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketName;
        private System.Windows.Forms.DataGridView DgAccount;
        private System.Windows.Forms.Label LblAccountOverview;
    }
}
