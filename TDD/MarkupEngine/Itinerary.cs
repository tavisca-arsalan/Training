using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupEngine
{
    public class Itinerary
    {
        public Itinerary(decimal baseRate, int stops = 0)
        {
            BaseFareInUSD = baseRate;
            NumberOfStops = stops;
        }

        public string OriginAirportCode { get; set; }

        public string DestinationAirportCode { get; set; }

        public TimeSpan FlightTime { get; set; }

        public int NumberOfStops { get; set; }

        public TimeSpan TotalLayoverTime { get; set; }

        public string Airline { get; set; }

        public DateTime UtcDepartureTime { get; set; }

        public DateTime UtcArrivalTime { get; set; }

        public decimal BaseFareInUSD { get; set; }

        public decimal MarkupInUSD { get; set; }

        public decimal TotalFareInUSD { get { return this.BaseFareInUSD + this.MarkupInUSD; } }

        public static readonly int MaxStops = 5;

        public static readonly decimal MaxLayoverTimeInHours = 15.0m;

        public static readonly TimeSpan MinFlightTime = new TimeSpan(2, 0, 0);

        public static readonly TimeSpan MaxFlightTime = new TimeSpan(4, 0, 0);
        
        //public int Stops { get; set; }

        //public decimal BaseRate { get; set; }

       
    }
}
