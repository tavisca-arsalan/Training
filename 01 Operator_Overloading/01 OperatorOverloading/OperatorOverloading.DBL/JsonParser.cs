using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Parse;

namespace OperatorOverloading.DBL
{
   public class JsonParser
    {
        readonly static string SOURCE = "source";
        private static string  _sourceCurrency= "USD";
       

        public static Dictionary<string, double> ParseJson(string jsonString,string sourceCurrency) 
        {
            Dictionary<String, double> rateDictionary = new Dictionary<String, double>();
            string[] blocks = jsonString.Split('{', '}');
            string[] sourceFinder = blocks[1].Split(',');
            string[] keyValue;

            foreach (string temp in sourceFinder)
            {
                if (temp.Contains(SOURCE))
                {
                    string[] template = temp.Split(':');
                    if (template[1].Contains(_sourceCurrency)==false)
                    {
                        throw new Exception("Rate list's source currency does not match the source currency provided by you!!");
                    }

                        string[] currencyRate = blocks[2].Split(',');
                        foreach (string individualRates in currencyRate)
                        {
                            keyValue = individualRates.Split(':');
                            keyValue[0] = keyValue[0].Trim();
                            keyValue[0] = keyValue[0].Remove(0, 4);
                            keyValue[0] = keyValue[0].Remove(keyValue[0].Length - 1, 1);
                            rateDictionary.Add(keyValue[0], double.Parse(keyValue[1]));
                        }
                        return rateDictionary;              
                }
            }
            return rateDictionary; // This will return a null dictionary object
        
        }

    }
}
