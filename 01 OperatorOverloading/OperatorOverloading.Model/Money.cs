using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Model
{
    public class Money
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Money()
        {
           
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
            if (!string.IsNullOrEmpty(m1.Currency) && !string.IsNullOrEmpty(m2.Currency) && string.Equals(m1.Currency,m2.Currency,StringComparison.OrdinalIgnoreCase))
            {
               
                currency =m1.Currency.ToUpper();
                amount = m1.Amount + m2.Amount;

                if (m1.Amount<=(double.MaxValue-m2.Amount))
                {
                    return (new Money(amount, currency));
                }
                else 
                {
                    throw new AmountOverflowException("Total amount generated was out of range");
                }
            }
            else 
            {
                throw new CurrencyMismatchException("Currency mismatch!!");
            }
     
        }

    }
}
