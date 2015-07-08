using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
     [Serializable]
    public class AmountOverflowException:Exception
    {
          
        public AmountOverflowException(string msg) : base(msg)
        {  
        }
        protected AmountOverflowException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
