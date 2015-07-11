using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Parse;
using System.IO;


namespace OperatorOverloading.DBL
{
    public class ExchangeRateProviderFromFile:IExchangeRateProvider
    {
       
        readonly static string PATH = "C:/Users/arsalang/Desktop/json.txt";

        public static Dictionary<String, double> dictionary = new Dictionary<String, double>();

        public double GetExchangeRate(string sourceCurrency,string targetCurrency)
        {
            double rate;
            string jsonString = File.ReadAllText(PATH);
            dictionary = JsonParser.ParseJson(jsonString,sourceCurrency.ToUpper());
            if (dictionary.TryGetValue(targetCurrency, out rate) == false)
            {
                throw new Exception("Currency " + targetCurrency + " not found in currency list.");
            }
            return rate;

        }

    }
}
