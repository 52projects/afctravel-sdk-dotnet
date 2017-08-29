using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Flight {
        public Flight() {
            Meals = new List<Meal>();
            Seats = new List<Seat>();
            Tickets = new List<Ticket>();
            Remarks = new List<Remark>();
        }
        public int FlightId { get; set; }
        public int ElementNumber { get; set; }
        public string Type { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureAirportName { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string DepartureTimezone { get; set; }
        public string DepartureTerminal { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string ArrivalAirportName { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public string ArrivalTimezone { get; set; }
        public string ArrivalChangeOfDay { get; set; }
        public string ArrivalTerminal { get; set; }
        public string Airlinecode { get; set; }
        public string AirlineName { get; set; }
        public int? FlightNumber { get; set; }
        public string OperatingAirlineCode { get; set; }
        public string OperatingAirlineName { get; set; }
        public int? OperatingFlightNumber { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentSupplierName { get; set; }
        public int NumberOfStops { get; set; }
        public string ClassOfService { get; set; }
        public string ClassOfServiceCabin { get; set; }
        public string ClassOfServiceCabinClass { get; set; }
        public int NumberInParty { get; set; }
        public string AirlineRecordLocator { get; set; }
        public DateTime? ConnectionDepartureDateTime { get; set; }
        public int Miles { get; set; }
        public string ActionCode { get; set; }
        public string Status { get; set; }
        public string Duration { get; set; }
        public int DurationInMinutes { get; set; }
        public string Layover { get; set; }
        public int? LayoverInMinutes { get; set; }
        public List<Meal> Meals { get; set; }
        public List<Seat> Seats { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Remark> Remarks { get; set; }
        public int Id { get; set; }

    }
}
