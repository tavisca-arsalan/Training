using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
    public class CurrencyException:Exception
    {
        public string EMessage { get; set; }
        public CurrencyException(string msg) 
        {
            EMessage = msg;       
        }
       
    }
}
