using System.Collections.Generic;

namespace My_Bittrex_2.Model
{
    public class Markets
    {
        public string MarketCurrency { get; set; }
        public string BaseCurrency { get; set; }
        public string MarketCurrencyLong { get; set; }
        public string BaseCurrencyLong { get; set; }
        public double MinTradeSize { get; set; }
        public string MarketName { get; set; }
        public bool IsActive { get; set; }
        public string Created { get; set; }
        public string Notice { get; set; }
        public bool? IsSponsored { get; set; }
        public string LogoUrl { get; set; }
    }

    public class MarketsWrapper
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<Markets> Result { get; set; }
    }
}