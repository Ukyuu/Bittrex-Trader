using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using My_Bittrex_2.Model;
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
            DgCurrency.AutoGenerateColumns = false;
            AddMarkets();
            AddAccount();
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
            DgCurrency.DataSource = _marketsBinding;
            DgAccount.DataSource = _accountCurrenciesBinding;
        }
    }
}
