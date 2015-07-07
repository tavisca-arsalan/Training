using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Model;

namespace OperatorOverloading.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            double temporaryAmount;
            string temporaryCurrency;

            //Take the input from user for first money object
            Console.WriteLine("Enter amount for first money object:");
            while (!double.TryParse(Console.ReadLine(), out  temporaryAmount))
            {
                Console.WriteLine("Please enter proper amount for first money object:");
            }
            Console.WriteLine("Enter currency(in upper case) for first money object:");
            temporaryCurrency = Console.ReadLine();
            Money moneyOne = new Money(temporaryAmount, temporaryCurrency);

            //Take the input from user for second money object
            Console.WriteLine("Enter amount for second money object:");
            while (!double.TryParse(Console.ReadLine(), out  temporaryAmount))
            {
                Console.WriteLine("Please enter proper amount for second money object:");
            }
            Console.WriteLine("Enter currency(in upper case) for first money object:");
            temporaryCurrency = Console.ReadLine();
            Money moneyTwo = new Money(temporaryAmount, temporaryCurrency);
            Money moneyThree = new Money();

            try
            {
                moneyThree = moneyOne + moneyTwo;
                Console.WriteLine("Third money object is:");
                Console.WriteLine("Total amount: {0} {1}", moneyThree.Amount, moneyThree.Currency);
            }
            catch (CurrencyMismatchException e) {
                Console.WriteLine(e.Message);
            }
            catch (AmountOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
           
            Console.ReadKey();
        }
    }
}
