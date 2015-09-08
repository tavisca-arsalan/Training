using MarkupEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FactorEvaluators
{
    public class StopFactorEvaluator:IDiscountingFactorCalculator
    {
        public StopFactorEvaluator(decimal weightOfStopsFactor) 
        {
            WeightOfStops = weightOfStopsFactor;
        }

        public decimal WeightOfStops { get; private set; }

        public decimal CalculateDiscountingFactor(Itinerary netRate)
        {
            return WeightOfStops / (decimal)Itinerary.MaxStops * netRate.NumberOfStops;
        }
    }
}
