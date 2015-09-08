using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarkupEngine;

namespace TDD.FactorEvaluators
{
    public class NightFlightFactorEvaluator:IDiscountingFactorCalculator
    {
        public NightFlightFactorEvaluator(decimal weightOfNightFlightFactor) 
        {
            WeightOfNightFlight = weightOfNightFlightFactor;
        }

        public decimal WeightOfNightFlight { get; private set; }

        public decimal CalculateDiscountingFactor(Itinerary netRate)
        {
            if (netRate.UtcDepartureTime.Hour >= 20 || netRate.UtcDepartureTime.Hour <= 6)
                return WeightOfNightFlight;
            return 0;
        }
    }
}
