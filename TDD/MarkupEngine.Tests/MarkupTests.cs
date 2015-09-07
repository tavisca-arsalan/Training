using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarkupEngine.Tests
{
    [TestClass]
    public class MarkupTests
    {
        [TestMethod]
        public void MarkupIsDeltaBetweenPublishedAndNetRateTest()
        {
            var calculator = new MarkupCalculator();
            var published = new Itinerary(150m);
            var netRate = new Itinerary(100) { UtcDepartureTime = new DateTime(2015, 3, 3, 8, 0, 0) };
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(50.0m, markup);
        }

        [TestMethod]
        public void PublishedRateLessThanNetRateShouldThrowTest()
        {
            var calculator = new MarkupCalculator();
            try
            {
                var published = new Itinerary(100m);
                var netRate = new Itinerary(150m);
                var markup = calculator.GetMarkup(published, netRate);
                Assert.Fail("Did not throw any errors.");
            }
            catch (FinanciallyUnviableRateException)
            {
            }
        }

        [TestMethod]
        public void MarkupShouldAlwaysBeGreaterThanDistributionCostTest()       // Verify the significance of test values
        {
            var calculator = new MarkupCalculator(10m);
            var published = new Itinerary(110m);
            var netRate = new Itinerary(100);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(0m, markup);
        }

        [TestMethod]
        public void MaxMarkupIsPublishedRateWithMinDiscountTest()
        {
            var calculator = new MarkupCalculator(10m, 15m);
            var published = new Itinerary(125m);
            var netRate = new Itinerary(100);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(0m, markup);
        }

        [TestMethod]
        public void MaxMarginShouldAlwaysBeGreaterThanDistributionCostTest()
        {
            var calculator = new MarkupCalculator(10m);
            try
            {
                var published = new Itinerary(109m);
                var netRate = new Itinerary(100);
                var markup = calculator.GetMarkup(published, netRate);
                Assert.Fail("Did not throw any errors.");
            }
            catch (FinanciallyUnviableRateException)
            {
            } 
        }


        [TestMethod]
        public void MarkupIsInverselyProportionalToNumberOfStopsTest()
        {
            decimal stopFactorWeight = 0.25m;
            var published = new Itinerary(20m, stops: 0);
            var netRate = new Itinerary(10, stops: 0)
            {
                UtcDepartureTime = new DateTime(2015, 12, 12, 8, 30, 00)
            };
            var calculator = new MarkupCalculator(0,0, weightOfStopsFactor:stopFactorWeight);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(10, markup);
        }

        [TestMethod]
        public void MaximumStopsImplyMinimumMarkupTest()
        {
            decimal stopFactorWeight = 0.25m;
            var published = new Itinerary(20m);
            var netRate = new Itinerary(10, stops: Itinerary.MaxStops) 
            { 
                UtcDepartureTime = new DateTime(2015, 12, 12, 8, 30, 00)
            };
            var calculator = new MarkupCalculator(0, 0, weightOfStopsFactor: stopFactorWeight);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(7.5m, markup);        // I have modified Nikhil's code here.
        }

        [TestMethod]
        public void MaxMarginShouldAlwaysExcludeDiscountTest()
        {
            var calculator = new MarkupCalculator(0, 10m);
            try
            {
                var published = new Itinerary(109m);
                var netRate = new Itinerary(100) { UtcDepartureTime = new DateTime(2015, 3, 3, 8, 0, 0) };
                var markup = calculator.GetMarkup(published, netRate);
                Assert.Fail("Did not throw any errors.");
            }
            catch (FinanciallyUnviableRateException)
            {
            }
        }

        [TestMethod]
        public void NightFlightShouldBeCheaperByItsFactorTest()
        {
            decimal nightFlightFactorWeight = 0.25m;
            var published = new Itinerary(20m);
            var netRate = new Itinerary(10, stops: 0)
            {
                UtcDepartureTime = new DateTime(2015, 12, 12, 21, 30, 00)
            };
            var calculator = new MarkupCalculator(0, 0, weightOfStopsFactor: nightFlightFactorWeight);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(7.5m, markup);        // I have modified Nikhil's code here.
        }

        [TestMethod]
        public void MarkupIsInverselyProportionalToTotalLayoverTest()
        {
            decimal layoverTimeFactorWeight = 0.25m;
            var published = new Itinerary(20m, stops: 0);
            var netRate = new Itinerary(10, stops: 0)
            {
                TotalLayoverTime=new TimeSpan(0,0,0),
                UtcDepartureTime = new DateTime(2015, 12, 12, 12, 00, 00)
            };
            var calculator = new MarkupCalculator(0, 0, weightOfLayoverTimeFactor: layoverTimeFactorWeight);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(10, markup);
        }

        [TestMethod]
        public void MaximumTotalLayoverHoursImplyMinimumMarkupTest()
        {
            decimal layoverTimeFactorWeight = 0.25m;
            var published = new Itinerary(20m, stops: 0);
            var netRate = new Itinerary(10, stops: 0)
            {
                TotalLayoverTime = new TimeSpan(15, 0, 0),
                UtcDepartureTime = new DateTime(2015, 12, 12, 12, 00, 00)
            };
            var calculator = new MarkupCalculator(0, 0, weightOfLayoverTimeFactor: layoverTimeFactorWeight);
            var markup = calculator.GetMarkup(published, netRate);
            Assert.AreEqual(7.5, markup);
        }

    }
}
