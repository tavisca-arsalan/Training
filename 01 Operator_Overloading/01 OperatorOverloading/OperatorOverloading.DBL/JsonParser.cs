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
        const string SOURCE = "source";
      
        public static Dictionary<string, double> ParseJson(string jsonString,string sourceCurrency) 
        {
            Dictionary<string, double> rateDictionary = new Dictionary<string, double>();
            string[] blocks = jsonString.Split('{', '}');
            string[] sourceFinder = blocks[1].Split(',');
            string[] keyValue;

            foreach (string temp in sourceFinder)
            {
                if (temp.Contains(SOURCE))
                {
                    string[] template = temp.Split(':');
                    if (template[1].Contains(sourceCurrency)==false)
                    {
                        throw new Exception("Rate list's source currency does not match the source currency provided by you!!");
                    }

                    double rateValue;
                    string[] currencyRate = blocks[2].Split(',');
                       
                    foreach (string individualRates in currencyRate)
                        {
                            keyValue = individualRates.Split(':');
                            keyValue[0] = keyValue[0].Trim();
                            keyValue[0] = keyValue[0].Remove(0, 4);
                            keyValue[0] = keyValue[0].Remove(keyValue[0].Length - 1, 1);
                            if (double.TryParse(keyValue[1], out rateValue) == false)
                            {
                                throw new Exception("Rate could not be fetched as a double!! ");
                            }
                                rateDictionary.Add(keyValue[0],rateValue);                           
                        }
                        return rateDictionary;              
                }
            }
            return rateDictionary; // This will return a null dictionary object
        
        }

    }
}
