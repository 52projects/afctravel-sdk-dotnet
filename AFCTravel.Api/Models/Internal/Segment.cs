using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace AFCTravel.Api.Models.Internal {
    public class Segment {
        public string ArrivalAirport { get; set; }
        public string DepartureAirport { get; set; }
        public DateTime DepartureDateTime { get; set; }
    }
}
