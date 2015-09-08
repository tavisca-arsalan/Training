using MarkupEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FactorEvaluators
{
    public class FlightTimeFactorEvaluator:IDiscountingFactorCalculator
    {
        public FlightTimeFactorEvaluator(decimal weightOfFlightTimeFactor)
        {
            WeightOfFlightTime = weightOfFlightTimeFactor;
        }

        public decimal WeightOfFlightTime { get; private set; }
    
        public decimal CalculateDiscountingFactor(Itinerary netRate)
        {
            decimal flightTimeInHours = netRate.FlightTime.Hours + netRate.FlightTime.Minutes / 60;
            decimal maxFlightTimeInHours = Itinerary.MaxFlightTime.Hours + Itinerary.MaxFlightTime.Minutes / 60;
            decimal minFlightTimeInHours = Itinerary.MinFlightTime.Hours + Itinerary.MinFlightTime.Minutes / 60;
            return WeightOfFlightTime / (maxFlightTimeInHours - minFlightTimeInHours) * (flightTimeInHours - minFlightTimeInHours);
        }
    }
}
