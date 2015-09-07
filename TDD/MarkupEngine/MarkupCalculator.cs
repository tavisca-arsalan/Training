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
                                decimal weightOfStopsFactor = 0.25m,decimal weightOfNightFlightFactor = 0.25m,
                                decimal weightOfLayoverTimeFactor = 0.25m
                                )
        {
            DistributionCost = distributionCost;
            MinimumDiscount = minDiscount;
            WeightOfStops=weightOfStopsFactor;
            WeightOfNightFlight = weightOfNightFlightFactor;
            WeightOfTotalLayoverTime = weightOfLayoverTimeFactor;
           
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
            decimal finalMarkup;
            decimal markupDeductionAgainstStops;
            decimal markupDeductionAgainstNightFlight;
            decimal markupDeductionAgainstLayoverTime;

            var discountedRate = published.BaseFareInUSD - MinimumDiscount;
            var maxMargin = discountedRate - netRate.BaseFareInUSD;
            if (maxMargin < DistributionCost)
                throw new FinanciallyUnviableRateException("This rate is not financially viable.");
            var maxMarkup = maxMargin - DistributionCost;       //Be Watchful here while updating final Markup into Itinerary.

            markupDeductionAgainstStops = WeightOfStops * maxMarkup * GetDiscountingStopFactor(netRate);
            markupDeductionAgainstNightFlight = WeightOfNightFlight * maxMarkup * IsNightFlight(netRate);
            markupDeductionAgainstLayoverTime = WeightOfTotalLayoverTime * maxMarkup * GetDiscountingLayoverFactor(netRate);

            finalMarkup = maxMarkup - markupDeductionAgainstNightFlight - markupDeductionAgainstStops - markupDeductionAgainstLayoverTime;
            return finalMarkup;
            // return WeightOfStopsFactor*(maxMarkup - (maxMarkup * GetDiscountingStopFactor(netRate)));
        }

        private decimal  GetDiscountingStopFactor(Itinerary netRate)
        {
            return 1.0m / (decimal)Itinerary.MaxStops * netRate.NumberOfStops;
        }

        private decimal GetDiscountingLayoverFactor(Itinerary netRate)
        {
            decimal layoverTimeInHours = netRate.TotalLayoverTime.Hours + netRate.TotalLayoverTime.Minutes / 60;
            return 1.0m / (Itinerary.MaxLayoverTimeInHours) * (layoverTimeInHours);
        }

        private decimal IsNightFlight(Itinerary netRate)
        {
            if (netRate.UtcDepartureTime.Hour >= 20 || netRate.UtcDepartureTime.Hour <= 6)
                return 1;
            return 0;
        }
    }
}
