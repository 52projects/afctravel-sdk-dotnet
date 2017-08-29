using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Seat {
        public int SeatId { get; set; }
        public int TravelerId { get; set; }
        public int FlightId { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public int Id { get; set; }
    }
}
