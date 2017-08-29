using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Ticket {
        public int TicketId { get; set; }
        public int TravelerId { get; set; }
        public int FlightId { get; set; }
        public string TicketImageResponse { get; set; }
        public string TicketNumber { get; set; }
        public string ConjoinedTicketNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
        public string TicketingPcc { get; set; }
        public string TicketingIata { get; set; }
        public string TicketingAgent { get; set; }
        public int Id { get; set; }
    }
}
