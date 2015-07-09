using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.CustomExceptions
{
   public  static class ExceptionThrower
    {
        public static void ThrowCurrencyMismatch()
        {
            throw new CurrencyMismatchException(ExceptionMessages.CurrencyMismatch);
        }

        public static void ThrowAmountOverflow()
        {
            throw new AmountOverflowException(ExceptionMessages.SumOverflow);
        }

        public static void ThrowNullObjectPassed()
        {
            throw new NullReferenceException(ExceptionMessages.NullObjectPassed);
        }

        public static void ThrowImproperValueForCurrency()
        {
            throw new NullReferenceException(ExceptionMessages.ImproperValueForCurrency);
        }

    }
}
