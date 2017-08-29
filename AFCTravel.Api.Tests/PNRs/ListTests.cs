using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit;
using NUnit.Framework;

namespace AFCTravel.Api.Tests.PNRs {
    [TestFixture]
    public class ListTests : Base {
        [Test]
        public void integration_pnrs_get_pnrs() {
            var pnrs = RestClient.PNRs.List(1050, 1267, "2bb3a87d5ac394cdac6432605f29dac1");
        }
    }
}
