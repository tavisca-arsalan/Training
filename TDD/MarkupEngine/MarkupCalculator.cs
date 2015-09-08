using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupEngine
{
    public class MarkupCalculator
    {
        public MarkupCalculator(decimal distributionCost = 0m, decimal minDiscount = 0m,
                                decimal weightOfStopsFactor = 0.25m, decimal weightOfNightFlightFactor = 0.25m,
                                decimal weightOfLayoverTimeFactor = 0.25m, decimal weightOfFlightTimeFactor = 0.25m)
        {
            DistributionCost = distributionCost;
            MinimumDiscount = minDiscount;
            WeightOfStops = weightOfStopsFactor;
            WeightOfNightFlight = weightOfNightFlightFactor;
            WeightOfTotalLayoverTime = weightOfLayoverTimeFactor;
            WeightOfFlightTime = weightOfFlightTimeFactor;
        }

        public decimal DistributionCost { get; set; }

        public decimal MinimumDiscount { get; set; }

        public decimal WeightOfStops { get; set; }

        public decimal WeightOfNightFlight { get; set; }

        public decimal WeightOfTotalLayoverTime { get; set; }

        public decimal WeightOfFlightTime { get; set; }


        public List<Itinerary> CalculateMarkup(Itinerary published, List<Itinerary> discounted)
        {
            throw new NotImplementedException();
        }

        public decimal GetMarkup(Itinerary published, Itinerary netRate)
        {

            decimal markupDeductionAgainstStops;
            decimal markupDeductionAgainstNightFlight;
            decimal markupDeductionAgainstLayoverTime;
            decimal markupDeductionAgainstFlightTime;
            decimal totalDeductionFactor;
            var discountedRate = published.BaseFareInUSD - MinimumDiscount;
            var maxMargin = discountedRate - netRate.BaseFareInUSD;
            if (maxMargin < DistributionCost)
                throw new FinanciallyUnviableRateException("This rate is not financially viable.");
            var maxMarkup = maxMargin - DistributionCost;       //Be Watchful here while updating final Markup into Itinerary.

            var stopsImpactCalculator = (IDiscountingFactorCalculator)Activator.CreateInstance(Type.GetType("TDD.FactorEvaluators.StopFactorEvaluator,TDD.FactorEvaluators"), WeightOfStops);
            markupDeductionAgainstStops = stopsImpactCalculator.CalculateDiscountingFactor(netRate);

            var nightflightImpactCalculator = (IDiscountingFactorCalculator)Activator.CreateInstance(Type.GetType("TDD.FactorEvaluators.NightFlightFactorEvaluator,TDD.FactorEvaluators"), WeightOfNightFlight);
            markupDeductionAgainstNightFlight = nightflightImpactCalculator.CalculateDiscountingFactor(netRate);
            
            var layoverTimeImpactCalculator = (IDiscountingFactorCalculator)Activator.CreateInstance(Type.GetType("TDD.FactorEvaluators.LayoverTimeFactorEvaluator,TDD.FactorEvaluators"), WeightOfTotalLayoverTime);
            markupDeductionAgainstLayoverTime = layoverTimeImpactCalculator.CalculateDiscountingFactor(netRate);

            var flightTimeImpactCalculator = (IDiscountingFactorCalculator)Activator.CreateInstance(Type.GetType("TDD.FactorEvaluators.FlightTimeFactorEvaluator,TDD.FactorEvaluators"), WeightOfTotalLayoverTime);
            markupDeductionAgainstFlightTime = flightTimeImpactCalculator.CalculateDiscountingFactor(netRate);

            totalDeductionFactor = markupDeductionAgainstNightFlight + markupDeductionAgainstStops + markupDeductionAgainstLayoverTime + markupDeductionAgainstFlightTime;
            return Math.Round(maxMarkup * (1 - totalDeductionFactor), 2);
        }

    }
}
