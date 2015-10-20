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
            this.lbl_Market = new System.Windows.Forms.Label();
            this.datgrid_Currency = new System.Windows.Forms.DataGridView();
            this.datgridcol_MarketCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datgridcol_MarketCurrencyLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datgridcol_MarketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datgrid_Account = new System.Windows.Forms.DataGridView();
            this.lbl_AccountOverview = new System.Windows.Forms.Label();
            this.tb_APIKey = new System.Windows.Forms.TextBox();
            this.lbl_APIKey = new System.Windows.Forms.Label();
            this.lbl_APISecret = new System.Windows.Forms.Label();
            this.tb_ApiSecret = new System.Windows.Forms.TextBox();
            this.btn_SaveKeys = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Market
            // 
            this.lbl_Market.AutoSize = true;
            this.lbl_Market.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Market.Location = new System.Drawing.Point(150, 13);
            this.lbl_Market.Name = "lbl_Market";
            this.lbl_Market.Size = new System.Drawing.Size(119, 17);
            this.lbl_Market.TabIndex = 0;
            this.lbl_Market.Text = "Available Markets";
            // 
            // datgrid_Currency
            // 
            this.datgrid_Currency.AllowUserToAddRows = false;
            this.datgrid_Currency.AllowUserToDeleteRows = false;
            this.datgrid_Currency.AllowUserToOrderColumns = true;
            this.datgrid_Currency.AllowUserToResizeRows = false;
            this.datgrid_Currency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datgrid_Currency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datgrid_Currency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid_Currency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datgridcol_MarketCurrency,
            this.datgridcol_MarketCurrencyLong,
            this.datgridcol_MarketName});
            this.datgrid_Currency.Location = new System.Drawing.Point(2, 42);
            this.datgrid_Currency.MultiSelect = false;
            this.datgrid_Currency.Name = "datgrid_Currency";
            this.datgrid_Currency.ReadOnly = true;
            this.datgrid_Currency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datgrid_Currency.ShowEditingIcon = false;
            this.datgrid_Currency.ShowRowErrors = false;
            this.datgrid_Currency.Size = new System.Drawing.Size(414, 775);
            this.datgrid_Currency.TabIndex = 1;
            // 
            // datgridcol_MarketCurrency
            // 
            this.datgridcol_MarketCurrency.DataPropertyName = "MarketCurrency";
            this.datgridcol_MarketCurrency.HeaderText = "Currency";
            this.datgridcol_MarketCurrency.Name = "datgridcol_MarketCurrency";
            this.datgridcol_MarketCurrency.ReadOnly = true;
            // 
            // datgridcol_MarketCurrencyLong
            // 
            this.datgridcol_MarketCurrencyLong.DataPropertyName = "MarketCurrencyLong";
            this.datgridcol_MarketCurrencyLong.HeaderText = "Currency Name";
            this.datgridcol_MarketCurrencyLong.Name = "datgridcol_MarketCurrencyLong";
            this.datgridcol_MarketCurrencyLong.ReadOnly = true;
            // 
            // datgridcol_MarketName
            // 
            this.datgridcol_MarketName.DataPropertyName = "MarketName";
            this.datgridcol_MarketName.HeaderText = "MarketName";
            this.datgridcol_MarketName.Name = "datgridcol_MarketName";
            this.datgridcol_MarketName.ReadOnly = true;
            // 
            // datgrid_Account
            // 
            this.datgrid_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid_Account.Location = new System.Drawing.Point(445, 78);
            this.datgrid_Account.Name = "datgrid_Account";
            this.datgrid_Account.Size = new System.Drawing.Size(1110, 739);
            this.datgrid_Account.TabIndex = 2;
            // 
            // lbl_AccountOverview
            // 
            this.lbl_AccountOverview.AutoSize = true;
            this.lbl_AccountOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountOverview.Location = new System.Drawing.Point(941, 13);
            this.lbl_AccountOverview.Name = "lbl_AccountOverview";
            this.lbl_AccountOverview.Size = new System.Drawing.Size(121, 17);
            this.lbl_AccountOverview.TabIndex = 4;
            this.lbl_AccountOverview.Text = "Account Overview";
            // 
            // tb_APIKey
            // 
            this.tb_APIKey.Location = new System.Drawing.Point(496, 52);
            this.tb_APIKey.Name = "tb_APIKey";
            this.tb_APIKey.Size = new System.Drawing.Size(221, 20);
            this.tb_APIKey.TabIndex = 5;
            // 
            // lbl_APIKey
            // 
            this.lbl_APIKey.AutoSize = true;
            this.lbl_APIKey.Location = new System.Drawing.Point(442, 55);
            this.lbl_APIKey.Name = "lbl_APIKey";
            this.lbl_APIKey.Size = new System.Drawing.Size(48, 13);
            this.lbl_APIKey.TabIndex = 6;
            this.lbl_APIKey.Text = "API KEY";
            // 
            // lbl_APISecret
            // 
            this.lbl_APISecret.AutoSize = true;
            this.lbl_APISecret.Location = new System.Drawing.Point(735, 55);
            this.lbl_APISecret.Name = "lbl_APISecret";
            this.lbl_APISecret.Size = new System.Drawing.Size(70, 13);
            this.lbl_APISecret.TabIndex = 8;
            this.lbl_APISecret.Text = "API SECRET";
            // 
            // tb_ApiSecret
            // 
            this.tb_ApiSecret.Location = new System.Drawing.Point(808, 52);
            this.tb_ApiSecret.Name = "tb_ApiSecret";
            this.tb_ApiSecret.Size = new System.Drawing.Size(221, 20);
            this.tb_ApiSecret.TabIndex = 7;
            // 
            // btn_SaveKeys
            // 
            this.btn_SaveKeys.Location = new System.Drawing.Point(1035, 50);
            this.btn_SaveKeys.Name = "btn_SaveKeys";
            this.btn_SaveKeys.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveKeys.TabIndex = 9;
            this.btn_SaveKeys.Text = "Save Keys";
            this.btn_SaveKeys.UseVisualStyleBackColor = true;
            this.btn_SaveKeys.Click += new System.EventHandler(this.btn_SaveKeys_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1116, 50);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset Keys";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_SaveKeys);
            this.Controls.Add(this.lbl_APISecret);
            this.Controls.Add(this.tb_ApiSecret);
            this.Controls.Add(this.lbl_APIKey);
            this.Controls.Add(this.tb_APIKey);
            this.Controls.Add(this.lbl_AccountOverview);
            this.Controls.Add(this.datgrid_Account);
            this.Controls.Add(this.datgrid_Currency);
            this.Controls.Add(this.lbl_Market);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1558, 820);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Market;
        private System.Windows.Forms.DataGridView datgrid_Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn datgridcol_MarketCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn datgridcol_MarketCurrencyLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn datgridcol_MarketName;
        private System.Windows.Forms.DataGridView datgrid_Account;
        private System.Windows.Forms.Label lbl_AccountOverview;
        private System.Windows.Forms.TextBox tb_APIKey;
        private System.Windows.Forms.Label lbl_APIKey;
        private System.Windows.Forms.Label lbl_APISecret;
        private System.Windows.Forms.TextBox tb_ApiSecret;
        private System.Windows.Forms.Button btn_SaveKeys;
        private System.Windows.Forms.Button btn_reset;
    }
}
