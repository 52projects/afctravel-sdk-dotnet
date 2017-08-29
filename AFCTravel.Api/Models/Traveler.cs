using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Traveler {
        public Traveler() {
            Seats = new List<Seat>();
            Tickets = new List<Ticket>();
        }
        public int TravelerId { get; set; }
        public string Type { get; set; }
        public int ElementNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public List<Seat> Seats { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
