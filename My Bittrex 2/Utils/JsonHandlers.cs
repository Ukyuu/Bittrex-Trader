using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;
using My_Bittrex_2.Model;
using Resp = My_Bittrex_2.Utils.JsonResponse;

namespace My_Bittrex_2.Utils
{
    internal class JsonHandlers
    {
        public static List<Markets> GetMarkets()
        {
            var uri = "https://bittrex.com/api/v1.1/public/getmarkets";
            var temp = new List<Markets>();
            var request = (HttpWebRequest) WebRequest.Create(uri);
            request.ContentType = "application/json";
            var response = (HttpWebResponse) request.GetResponse();
            var stream = response.GetResponseStream();
            Resp.GetValue(stream, temp);
            response.Close();
            return temp;
        }

        public static List<AccountCurrencies> GetAccountCurrencies()
        {
            // TODO : add a way to get this from the user
            var apiKey = ApiKey;
            var apiSecret = ApiSecret;

            var nonce = (int) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds; // same as time() in PHP
            var encoding = Encoding.UTF8;
            var url = @"https://bittrex.com/api/v1.1/account/getbalances?apikey=" + apiKey;
            var urlForAuth = url + "&nonce=" + nonce;
            var result = Gethmacsha512(encoding, apiSecret, urlForAuth);

            // some var for the request
            var account = new List<AccountCurrencies>();

            // sending it to get the response
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("apisign",result);
            request.Headers.Add("nonce", nonce.ToString());
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            
            Resp.GetValue(stream, account);
            return account;
        }

        private static string ApiSecret => "fdb2069401b2458294b7b693d78e6a0f"; // This is just a read-only API Key for test purpose

        private static string ApiKey => "80232d40f3c74fd2bf4c61be0e2ef717"; // Read-only API key for test purpose

        private static string Gethmacsha512(Encoding encoding, string apiSecret, string url)
        {
            // doing the encoding
            var keyByte = encoding.GetBytes(apiSecret);
            string result;
            using (var hmacsha512 = new HMACSHA512(keyByte))
            {
                hmacsha512.ComputeHash(encoding.GetBytes(url));

                result = ByteToString(hmacsha512.Hash);
            }
            return result;
        }

        static string ByteToString(IEnumerable<byte> buff)
        {
            return buff.Aggregate("", (current, t) => current + t.ToString("X2"));
        }
    }
}