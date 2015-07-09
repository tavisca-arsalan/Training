using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.CustomExceptions
{
     [Serializable]
    public class AmountOverflowException:Exception
    {
          
        public AmountOverflowException(string msg) : base(msg)
        {  
        }

        public AmountOverflowException( string msg, Exception inner ) : base( msg, inner )
        { 
        }

        protected AmountOverflowException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
