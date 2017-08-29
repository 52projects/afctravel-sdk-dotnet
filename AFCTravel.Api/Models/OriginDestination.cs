using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class OriginDestination {
        public OriginDestination() {
            Flights = new List<Flight>();
        }
        public int OriginDestinationId { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureAirportName { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string DepartureTimezone { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string ArrivalAirportName { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string ArrivalTimezone { get; set; }
        public string Duration { get; set; }
        public int DurationInMinutes { get; set; }
        public List<Flight> Flights { get; set; }
    }
}
