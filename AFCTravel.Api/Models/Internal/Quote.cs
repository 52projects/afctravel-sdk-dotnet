using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models.Internal {
    public class Quote {
        public Quote() {
            Segments = new List<Segment>();
        }

        public int NumberOfPassengers { get; set; }
        public bool SegmentTextChanged { get; set; }

        public List<Segment> Segments { get; set; }
    }
}
