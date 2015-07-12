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
        public string Path = ConfigurationManager.AppSettings["Path"];
        public static Dictionary<string, double> Dictionary = new Dictionary<string, double>();

        public double GetExchangeRate(string sourceCurrency,string targetCurrency)
        {
            double rate;
            string jsonString = File.ReadAllText(Path);
            Dictionary = JsonParser.ParseJson(jsonString,sourceCurrency.ToUpper());
            if (Dictionary.TryGetValue(targetCurrency, out rate) == false)
            {
                throw new Exception("Currency " + targetCurrency + " not found in currency list.");
            }
            return rate;

        }

    }
}
