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
        private double amount;
        private string currency;
        public double Amount {
            get { return amount; }
            set {amount = value;}
        }


        public string Currency {
            get { return currency; }
            set {
                if (string.IsNullOrWhiteSpace(value) == false)
                {
                    currency = value;
                }
                else
                {
                    throw new NullReferenceException(ExceptionMessages.NullValueForCurrency);   
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
            double amount;
            string currency;
            if (string.Equals(m1.Currency,m2.Currency,StringComparison.OrdinalIgnoreCase))
            {
               
                currency =m1.Currency.ToUpper();
                amount = m1.Amount + m2.Amount;

                if (double.IsPositiveInfinity(amount)==false)
                {
                    return (new Money(amount, currency));
                }
                else 
                {
                    throw new AmountOverflowException(ExceptionMessages.SumOverflow);
                }
            }
            else 
            {
                throw new CurrencyMismatchException(ExceptionMessages.CurrencyMismatch);
            }
     
        }

    }
}
