using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Parse;
using System.IO;
using System.Configuration;

namespace OperatorOverloading.DBL
{
    public class FileExchangeRateProvider:IExchangeRateProvider
    {
       
     //   public string Path = "C:/Users/arsalang/Desktop/json.txt";
        private string _path = ConfigurationManager.AppSettings["Path"];
        private Dictionary<string, double> _exchangeRates = new Dictionary<string, double>();

        public double GetExchangeRate(string sourceCurrency,string targetCurrency)
        {
            double rate;
            string jsonString = File.ReadAllText(_path);
            _exchangeRates = JsonParser.ParseJson(jsonString,sourceCurrency.ToUpper());
            if (_exchangeRates.TryGetValue(targetCurrency, out rate) == false)
            {
                throw new Exception("Currency " + targetCurrency + " not found in currency list.");
            }
            return rate;

        }

    }
}
