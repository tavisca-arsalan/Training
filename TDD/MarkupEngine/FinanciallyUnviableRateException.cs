using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupEngine
{
    [Serializable]
    public class FinanciallyUnviableRateException : Exception
    {
        public FinanciallyUnviableRateException() { }
        public FinanciallyUnviableRateException(string message) : base(message) { }
        public FinanciallyUnviableRateException(string message, Exception inner) : base(message, inner) { }
        protected FinanciallyUnviableRateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
