using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupEngine
{
    public interface IDiscountingFactorCalculator
    {
        decimal CalculateDiscountingFactor(Itinerary netRate);
    }
}
