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
            if (m1.Currency.Equals(m2.Currency))
            {
                if (m1.Amount==double.MaxValue || m1.Amount < 0 || m2.Amount==double.MaxValue || m2.Amount < 0)
                {
                    throw new AmountException("You entered too large value for amount");
                }

                currency = m1.Currency;
                amount = m1.Amount + m2.Amount;

                if (m1.Amount<=(double.MaxValue-m2.Amount))
                {
                    return (new Money(amount, currency));
                }
                else 
                {
                    throw new AmountException("Total amount generated was out of range");
                }
            }
            else 
            {
                throw new CurrencyException("Currency mismatch!!");
            }
     
        }

    }
}
