using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverloading.Model;
using OperatorOverloading.CustomExceptions;

namespace OperatorOverloading.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            double temporaryAmount;
            string temporaryCurrency;
            Money moneyOne = null;
            Money moneyTwo = null;

            //Take the input from user for first money object
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
                //Take the input from user for second money object
                Console.WriteLine("Enter amount for second money object:");
                while (double.TryParse(Console.ReadLine(), out  temporaryAmount) == false)
                {
                    Console.WriteLine("Please enter proper amount for second money object:");
                }

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter currency for second money object:");
                        temporaryCurrency = Console.ReadLine();
                        moneyTwo = new Money(temporaryAmount, temporaryCurrency);
                        break;
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                Money moneyThree = moneyOne + moneyTwo;
                Console.WriteLine("Third money object(sum of the two that you just entered) is:");
                Console.WriteLine("Total amount: {0} {1}", moneyThree.Amount, moneyThree.Currency);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadKey();
        }
    }
}
