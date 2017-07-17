using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit;
using NUnit.Framework;

namespace AFCTravel.Api.Tests.Trips {
    [TestFixture]
    public class GetTests : Base {
        [Test]
        public void integration_trips_get_trip() {
            var trip = RestClient.Trips.Get("1050");
            trip.ShouldNotBe(null);
        }
    }
}
