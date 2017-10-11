using Shouldly;
using NUnit;
using System;
using NUnit.Framework;
using AFCTravel.Api.Models.Internal;
using System.Configuration;


namespace AFCTravel.Api.Tests.Trips {
    [TestFixture]
    public class CreateTests : Base {
        [Test]
        public void integration_trips_create_trip() {
            RestClient = new AFCTravelRestClient(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["SecretKey"], ConfigurationManager.AppSettings["AccessCode"], "https://test.managedtrip.com/ManagedTrip/api/partner/1.0");
            var internalTrip = new InternalTrip();
            var rnd = new Random();

            internalTrip.Brand.BrandId = 1;
            internalTrip.Client.Cac = "FMLEAD";
            internalTrip.Status = "Open";
            internalTrip.TripType = "Group";
            internalTrip.Progress = "Quote";
            internalTrip.TravelFromDate = DateTime.UtcNow.AddMonths(7);
            internalTrip.TravelToDate = DateTime.UtcNow.AddMonths(8);
            internalTrip.Name = "Focus test trip " + rnd.Next(1, 100000);
            internalTrip.InternalNotes = "Created by Focus";

            var quote = new Quote();
            quote.NumberOfPassengers = 22;
            quote.SegmentTextChanged = false;

            quote.Segments.Add(new Segment {
                ArrivalAirport = "DFW",
                DepartureAirport = "SDQ",
                DepartureDateTime = DateTime.UtcNow.AddMonths(7)
            });

            internalTrip.Quotes.Add(quote);

            var result = RestClient.Trips.CreateTrip(internalTrip);
            result.TripID.ShouldBeGreaterThan(0);
        }
    }
}
