using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using My_Bittrex_2.Model;

namespace My_Bittrex_2.Utils
{
    internal class JsonResponse
    {
        public static void GetValue(Stream stream, List<Markets> temp)
        {
            MarketsWrapper w = null;

            if (stream != null)
            {
                var re = new StreamReader(stream);
                var json = re.ReadToEnd();
                w = (MarketsWrapper) new JavaScriptSerializer().Deserialize(json, typeof (MarketsWrapper));
            }
            if (w == null || !w.Success) return;
            var allResults = new ObservableCollection<Markets>(w.Result);
            var temp2 = new ObservableCollection<Markets>();
            foreach (var getMarketResult in allResults.Where(getMarketResult => getMarketResult.IsActive))
            {
                temp2.Add(getMarketResult);
            }

            temp.AddRange(temp2);
        }

        public static void GetValue(Stream stream, List<AccountCurrencies> temp)
        {
            var w = new AccountWrapper();

            if (stream != null)
            {
                var re = new StreamReader(stream);
                var json = re.ReadToEnd();
                w = (AccountWrapper) new JavaScriptSerializer().Deserialize(json, typeof (AccountWrapper));
            }
            if (w == null || !w.Success) return;
            if (w.AccountCurrencies == null || w.AccountCurrencies.Length <= 0)
            {
                MessageBox.Show(w.Message);
            }
            else
            {
                var allResults = new ObservableCollection<AccountCurrencies>(w.AccountCurrencies);
                var temp2 = new ObservableCollection<AccountCurrencies>();
                foreach (var getAccountResult in allResults)
                {
                    temp2.Add(getAccountResult);
                }
                temp.AddRange(temp2);
            }



        }
    }
}