using Rovia_1.HotelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Rovia_1
{
    public partial class _Default : Page
    {
        private const string API_KEY = "AIzaSyAdNsGS6rHc76FXF_YNOxIph4PpfkZEfWI";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<int> ages = new List<int>();
            ages.Add(35);
            ages.Add(34);
            string address = "HongKong,Korea";
            var requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?address={0}&key={1}",address,API_KEY);

            var geoCodeRequest = WebRequest.Create(requestUri);
            var geoCodeResponse = geoCodeRequest.GetResponse();
            var xdoc = XDocument.Load(geoCodeResponse.GetResponseStream());

            var result = xdoc.Element("GeocodeResponse").Element("result");
            var locationElement = result.Element("geometry").Element("location");
            var latitude = locationElement.Element("lat");
            var longitude = locationElement.Element("lng");


            HotelSearchViewRQ hotelSearchRequest = new HotelSearchViewRQ();
            hotelSearchRequest.SessionId = Guid.NewGuid().ToString();
            

            hotelSearchRequest.PagingInfo = new PagingInfo
            {
                Enabled= true,
                StartNumber=0,
                EndNumber=20,
                TotalRecordsBeforeFiltering=0,
                TotalResults=0
            };

            #region HotelSearchCriterion
            hotelSearchRequest.HotelSearchCriterion = new HotelSearchCriterion();
            hotelSearchRequest.HotelSearchCriterion.Attributes = new List<HotelEngine.StateBag>();
            hotelSearchRequest.HotelSearchCriterion.Attributes.Add(new HotelEngine.StateBag { Name = "API_SESSION_ID", Value = hotelSearchRequest.SessionId });
            hotelSearchRequest.HotelSearchCriterion.MaximumResults = 500;
            hotelSearchRequest.HotelSearchCriterion.Pos = new PointOfSale
            {
                PosId = 4, //5, 201, 206    4, 101, 106
                Requester = new Company 
                {
                    FullName = "Rovia",
                    DK = "200000D"
                }
            };
            var passengertypeQuantities = new List<PassengerTypeQuantity>();
            passengertypeQuantities.Add(new PassengerTypeQuantity()
                                        {
                                            Ages = ages,
                                            PassengerType = 0,
                                            Quantity = 2
                                        });

            hotelSearchRequest.HotelSearchCriterion.RoomOccupancyTypes = new List<RoomOccupancyType>();
            hotelSearchRequest.HotelSearchCriterion.RoomOccupancyTypes.Add(new RoomOccupancyType
            {
                PaxQuantities = passengertypeQuantities
            });
            
            hotelSearchRequest.HotelSearchCriterion.Location = new Location();
            hotelSearchRequest.HotelSearchCriterion.Location = new City
            {
                GeoCode = new GeoCode { Latitude = 18.5204303f, Longitude = 73.8567437f },             
                Name = "Pune",
                Country = "IN"
            };
            //hotelSearchRequest.HotelSearchCriterion.Location.GmtOffsetMinutes = 0;
            //hotelSearchRequest.HotelSearchCriterion.Location.Id = 338298;
            //hotelSearchRequest.HotelSearchCriterion.Location.Name = "HongKong Hotel";

            //hotelSearchRequest.HotelSearchCriterion.Location.CodeContext =0;
            
            //hotelSearchRequest.HotelSearchCriterion.Location.GeoCode = new GeoCode();
           

            //hotelSearchRequest.HotelSearchCriterion.Location.GeoCode.Latitude = (float)latitude;
            //hotelSearchRequest.HotelSearchCriterion.Location.GeoCode.Longitude = (float)longitude;

            hotelSearchRequest.HotelSearchCriterion.StayPeriod = new DateTimeSpan();
            hotelSearchRequest.HotelSearchCriterion.StayPeriod.Start = new DateTime(2015,09,28,00,00,00);
            hotelSearchRequest.HotelSearchCriterion.StayPeriod.End = new DateTime(2015, 09, 29, 00, 00, 00);
            
            hotelSearchRequest.HotelSearchCriterion.Guests = new List<PassengerTypeQuantity>();
            hotelSearchRequest.HotelSearchCriterion.Guests = passengertypeQuantities;

            hotelSearchRequest.HotelSearchCriterion.PriceCurrencyCode = "USD";
            hotelSearchRequest.HotelSearchCriterion.ProcessingInfo = new HotelSearchProcessingInfo
            {
                DisplayOrder = HotelDisplayOrder.ByPriceLowToHigh
            };
            hotelSearchRequest.HotelSearchCriterion.NoOfRooms = 1;
            hotelSearchRequest.HotelSearchCriterion.SearchType = HotelSearchType.City;

            hotelSearchRequest.Transforms = new List<HotelTransform> 
            {
                new HotelFilterTransform(),
                new HotelItineraryTransform()
            };
            
            #endregion

            using (HotelEngineViewClient client = new HotelEngineViewClient())
            {
                var response = client.HotelSearchView(hotelSearchRequest);                
            }
        }
    }
}