using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Quote {
        public Quote() {
            this.Segments = new List<Segment>();
        }
        public string AirlineRecordLocator { get; set; }
        public string ApiETicketPDFUrl { get; set; }
        public string ApiETicketUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string FareType { get; set; }
        public string Notes { get; set; }
        public int NumberOfPassengers { get; set; }
        public int QuoteNumber { get; set; }
        public string RecordLocator { get; set; }
        public List<Segment> Segments { get; set; }
    }
}
