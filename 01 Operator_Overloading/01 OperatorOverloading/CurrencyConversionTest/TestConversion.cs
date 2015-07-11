using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatorOverloading.Model;

namespace OperatorOverloading.UnitTest
{
    [TestClass]
    public class TestConversion
    {
        [TestMethod]
        public void CheckValidity()
        {
            Money moneyOne = new Money(100,"usd");
            Money moneyTwo = moneyOne.Convert("inr");

            Assert.IsTrue(moneyTwo.Amount== 6347.345);
        }

        [TestMethod]
        [ExpectedException (typeof(NullReferenceException))]
        public void CheckForNullObject()
        {
            Money moneyOne = null;
            Money moneyTwo = moneyOne.Convert("inr");

        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CheckCurrencySource()
        {
            Money moneyOne = new Money(100, "us");
            Money moneyTwo = moneyOne.Convert("inr");

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckCurrencyTarget()
        {
            Money moneyOne = new Money(100, "usd");
            Money moneyTwo = moneyOne.Convert("im");

        }
    }
}
