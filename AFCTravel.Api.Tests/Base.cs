using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using System.Configuration;

namespace AFCTravel.Api.Tests {
    public class Base {
        internal AFCTravelRestClient RestClient;

        [OneTimeSetUp]
        public void Setup() {
            RestClient = new AFCTravelRestClient(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["SecretKey"], ConfigurationManager.AppSettings["AccessCode"]);
        }
    }
}
