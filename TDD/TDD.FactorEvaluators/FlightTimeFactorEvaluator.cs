using MarkupEngine;
using System;
using System.Collections.Generic;
using System.Configuration;
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

    public abstract class DiscountingFactor
    {
        protected DiscountingFactor(decimal weight)
        {
            Weight = weight;
        }

        public decimal Weight { get; private set; }

        protected decimal GetDiscountingFactor(Itinerary itinerary);

        public decimal GetDiscount(Itinerary itinerary)
        {
            return this.Weight * this.GetDiscountingFactor(itinerary);
        }
    }

    public class MarkupCalculator
    {
        public List<DiscountingFactor> Factors = new List<DiscountingFactor>();

        public MarkupCalculator()
        {
            this.Factors = ConfigurationManager
                                .AppSettings
                                .Keys.Cast<string>()
                                .Where(k => k.StartsWith("factors_", StringComparison.OrdinalIgnoreCase) == true)
                                .Select(k => ConfigurationManager.AppSettings[k])
                                .Select(v => v.Split('|'))
                                .Select(t => Activator.CreateInstance(Type.GetType(t[0]), decimal.Parse(t[1])) as DiscountingFactor)
                                .ToList();
                                
        }

        public decimal CalculateMarkup(Itinerary itinerary)
        {
            var markup = GetMaxMarkup(itinerary);
            var normalizedFactor = this.Factors.Select(f => f.GetDiscount(itinerary)).Average();
            return markup - markup * normalizedFactor;
        }

        private decimal GetMaxMarkup(Itinerary itinerary)
        {
            throw new NotImplementedException();
        }
    }

    
}
