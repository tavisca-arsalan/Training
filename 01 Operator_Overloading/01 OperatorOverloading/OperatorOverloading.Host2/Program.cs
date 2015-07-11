using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Model;

namespace OperatorOverloading.Host2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            double temporaryAmount;
            string temporaryCurrency;
            Money moneyOne = null;
            try
            {

                Console.WriteLine("Enter amount for first money object:");
                while (double.TryParse(Console.ReadLine(), out  temporaryAmount) == false)
                {
                    Console.WriteLine("Please enter proper amount for first money object:");
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter currency for first money object:");
                        temporaryCurrency = Console.ReadLine();
                        moneyOne = new Money(temporaryAmount, temporaryCurrency);
                        break;
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                Console.WriteLine("Enter Target currency");
                Money moneyTwo = moneyOne.Convert(Console.ReadLine());
                Console.WriteLine("Fourth money object is:");
                Console.WriteLine("Total amount: {0} {1}", moneyTwo.Amount, moneyTwo.Currency);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
