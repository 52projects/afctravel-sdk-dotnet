using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Segment {
        public string AircraftType { get; set; }
        public string AirlineCode { get; set; }
        public string AirlineName { get; set; }
        public string AirlineRecordLocator { get; set; }
        public string ArrivalAirport { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string ArrivalTerminal { get; set; }
        public string BookingClass { get; set; }
        public string CodeShareInfo { get; set; }
        public string DepartureAirport { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureCity { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string DepartureTerminal { get; set; }
        public string FlightNumber { get; set; }
        public string FlightTime { get; set; }
        public string MealInfo { get; set; }
        public int Miles { get; set; }
        public string Seats { get; set; }
        public int SegmentNumber { get; set; }
        public string Status { get; set; }
        public int Stops { get; set; }
    }
}
