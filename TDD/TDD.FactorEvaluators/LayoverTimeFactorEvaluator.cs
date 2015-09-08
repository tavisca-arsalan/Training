using MarkupEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.FactorEvaluators
{
    public class LayoverTimeFactorEvaluator:IDiscountingFactorCalculator
    {
        public LayoverTimeFactorEvaluator(decimal weightOfLayoverTimeFactor)
        {
            WeightOfTotalLayoverTime = weightOfLayoverTimeFactor;
        }

        public decimal WeightOfTotalLayoverTime { get; private set; }

        public decimal CalculateDiscountingFactor(Itinerary netRate)
        {
            decimal layoverTimeInHours = netRate.TotalLayoverTime.Hours + netRate.TotalLayoverTime.Minutes / 60;
             return WeightOfTotalLayoverTime / (Itinerary.MaxLayoverTimeInHours) * (layoverTimeInHours);
        }

    }
}
