using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class PNR {
        public PNR() {
            OriginDestinations = new List<OriginDestination>();
            Travelers = new List<Traveler>();
            Remarks = new List<Remark>();
            AirlineMap = new List<dynamic>();
            AirportMap = new List<dynamic>();
        }
        public int PnrId { get; set; }
        public int TripId { get; set; }
        public string RecordLocator { get; set; }
        public string PseudoCityCode { get; set; }
        public string Cac { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime EarliestDepartureDateTime { get; set; }
        public string EarliestDepartureTimezone { get; set; }
        public DateTime EarliestDepartureTimeUtc { get; set; }
        public DateTime LatestArrivalDateTime { get; set; }
        public string LatestArrivalTimezone { get; set; }
        public DateTime LatestArrivalDateTimeUtc { get; set; }
        public int NumberOfTravelers { get; set; }
        public bool GroupPnr { get; set; }
        public List<OriginDestination> OriginDestinations { get; set; }
        public List<Traveler> Travelers { get; set; }
        public List<Remark> Remarks { get; set; }
        public List<dynamic> AirlineMap { get; set; }
        public List<dynamic> AirportMap { get; set; }
        public string AccessCode { get; set; }
    }
}
