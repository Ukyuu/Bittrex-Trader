using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using My_Bittrex_2.Model;
using My_Bittrex_2.Properties;
using My_Bittrex_2.Utils;

namespace My_Bittrex_2.Views
{
    public partial class MainView : UserControl
    {
        readonly BindingList<Markets> _marketsBinding = new BindingList<Markets>();
        readonly BindingList<AccountCurrencies>  _accountCurrenciesBinding = new BindingList<AccountCurrencies>();
             
        public MainView()
        {
            InitializeComponent();
            datgrid_Currency.AutoGenerateColumns = false;
            AddMarkets();
            if (string.IsNullOrEmpty(Settings.Default.APIKey) && string.IsNullOrEmpty(Settings.Default.APISecret))
            {
                btn_SaveKeys.Enabled = true;
            }
            else
            {
                btn_SaveKeys.Enabled = false;
                AddAccount();
            }
            
        }

        private void AddAccount()
        {
            var temp = JsonHandlers.GetAccountCurrencies();
            foreach (var accountCurrency in temp)
            {
              _accountCurrenciesBinding.Add(accountCurrency);
            }
        }

        private void AddMarkets()
        {
            var temp = JsonHandlers.GetMarkets().Where(s => s.IsActive == true);
            foreach (var mMarket in temp)
            {
                _marketsBinding.Add(mMarket);
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            datgrid_Currency.DataSource = _marketsBinding;
            datgrid_Account.DataSource = _accountCurrenciesBinding;
        }

        private void btn_SaveKeys_Click(object sender, EventArgs e)
        {
            Settings.Default.APIKey = tb_APIKey.Text;
            Settings.Default.APISecret = tb_ApiSecret.Text;
            AddAccount();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Settings.Default.APIKey = "";
            Settings.Default.APISecret = "";
            btn_SaveKeys.Enabled = true;
        }
    }
}
