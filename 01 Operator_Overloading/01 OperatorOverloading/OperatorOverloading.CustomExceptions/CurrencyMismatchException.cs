﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.CustomExceptions
{
    [Serializable]
    public class CurrencyMismatchException:Exception
    {
           
        public CurrencyMismatchException(string msg) :base(msg)
        {
        }

        public CurrencyMismatchException( string msg, Exception inner ) : base( msg, inner )
        { 
        }

        protected CurrencyMismatchException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
       
    }
}
