using Rovia_1.HotelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rovia_1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> ages = new List<int>();
            ages.Add(35);
            ages.Add(34);
            HotelSearchViewRQ hotelSearchRequest = new HotelSearchViewRQ();
            hotelSearchRequest.HotelSearchCriterion.Location.GeoCode.Latitude =37.74283F;
            hotelSearchRequest.HotelSearchCriterion.Location.GeoCode.Longitude = 127.05265F;

            hotelSearchRequest.HotelSearchCriterion.StayPeriod.Start = new DateTime(2015,09,09,00,00,00);
            hotelSearchRequest.HotelSearchCriterion.StayPeriod.Start = new DateTime(2015, 09, 12, 00, 00, 00);

            hotelSearchRequest.HotelSearchCriterion.Guests.Add(new PassengerTypeQuantity()
            {
                Ages =ages,PassengerType=0,Quantity=2
            });

            using (HotelEngineViewClient client = new HotelEngineViewClient())
            {
                var response = client.HotelSearchView(hotelSearchRequest);
                
            }
        }
    }
}