using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorOverloading.Model;
namespace UnitTests
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
       // [ExpectedException(typeof(Exception))]
        public void TestConvertMethod()
        {
            Money moneyOne = new Money(128, "INR");
            Money moneyTwo = moneyOne.Convert("USD");
            Console.WriteLine("Fourth money object is:");
            Console.WriteLine("Total amount: {0} {1}", moneyTwo.Amount, moneyTwo.Currency);
        }

        // [TestMethod]
        //public void TestConvertMethod()
        //{
        //}
    }
}
