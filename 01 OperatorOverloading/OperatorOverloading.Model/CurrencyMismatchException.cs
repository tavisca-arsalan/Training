using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
    [Serializable]
    public class CurrencyMismatchException:Exception
    {
        
        public CurrencyMismatchException(string msg) :base(msg)
        {
        }
       
    }
}
