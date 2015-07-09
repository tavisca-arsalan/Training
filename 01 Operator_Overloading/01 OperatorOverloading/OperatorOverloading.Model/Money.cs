using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.CustomExceptions;

namespace OperatorOverloading.Model
{
    public class Money
    {
        private double _amount;
        private string _currency;
        public double Amount {
            get { return _amount; }
            set {_amount = value;}
        }


        public string Currency {
            get { return _currency; }
            set {
                if (string.IsNullOrWhiteSpace(value) == false && value.Length==3)
                {
                    _currency = value;
                }
                else
                {
                    CustomExceptions.ExceptionThrower.ThrowImproperValueForCurrency(); ;   
                }
                
               }
        }

       
        public Money(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public static Money operator +(Money m1, Money m2)
        {
            
           // string currency;
            Validate(m1, m2);
            return new Money(m1.Amount+m2.Amount,m1.Currency.ToUpper());
     
        }


        private static void Validate(Money m1, Money m2)
        {
            if (m1 != null && m2 != null)
            {
       
                if (string.Equals(m1.Currency, m2.Currency, StringComparison.OrdinalIgnoreCase))
                {

                    if (double.IsInfinity(m1.Amount + m2.Amount) == true)
                    {
                        CustomExceptions.ExceptionThrower.ThrowAmountOverflow();
                    }
                }
                else
                {
                    CustomExceptions.ExceptionThrower.ThrowCurrencyMismatch();
                }
            }
            else
            {
                CustomExceptions.ExceptionThrower.ThrowNullObjectPassed();
            }
        }
    }
}
