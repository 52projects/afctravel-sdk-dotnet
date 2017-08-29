using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Remark {
        public int RemarkId { get; set; }
        public int ElementNumber { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public int? TravelerId { get; set; }
        public int? FlightId { get; set; }
        public int Id { get; set; }
    }
}
