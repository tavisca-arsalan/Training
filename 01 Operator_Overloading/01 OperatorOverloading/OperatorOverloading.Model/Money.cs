using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.CustomExceptions;
using OperatorOverloading.DBL;

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
                    _currency = value.ToUpper();
                }
                else
                {
                    CustomExceptions.ExceptionThrower.ThrowImproperValueForCurrency(); ;   
                }
                
               }
        }

        public Money()
        { 
        }
       
        public Money(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public static Money operator +(Money money1, Money money2)
        {
            
           // string currency;
            Validate(money1, money2);
            return new Money(money1.Amount+money2.Amount,money1.Currency.ToUpper());
     
        }

        public Money Convert(string targetCurrency)
        {
            double rate;
            // currency value validation here:

            if (string.IsNullOrWhiteSpace(targetCurrency) == true && targetCurrency.Length != 3)
            {
                CustomExceptions.ExceptionThrower.ThrowImproperValueForCurrency();
            }
            if (this.Currency.Equals("USD") == false && targetCurrency.ToUpper().Equals("USD") == false)
            {
                throw new Exception("Either of two currencies must be USD!!");
            }
            if (this.Currency.Equals("USD"))
            {
                FileExchangeRateProvider provideExchangeRate = new FileExchangeRateProvider();
                rate = provideExchangeRate.GetExchangeRate(this.Currency, targetCurrency.ToUpper());
                return new Money(this.Amount * rate, targetCurrency.ToUpper());
            }
            else
            {
                FileExchangeRateProvider provideExchangeRate = new FileExchangeRateProvider();
                rate = provideExchangeRate.GetExchangeRate(targetCurrency.ToUpper(), this.Currency);
                if (this.Amount == 0)
                {
                    return new Money(0, targetCurrency.ToUpper());
                }

                return new Money(this.Amount / rate, targetCurrency.ToUpper());
            }
        }

        private static void Validate(Money money1, Money money2)
        {
            if (money1 != null && money2 != null)
            {
       
                if (string.Equals(money1.Currency, money2.Currency, StringComparison.OrdinalIgnoreCase))
                {

                    if (double.IsInfinity(money1.Amount + money2.Amount) == true)
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
