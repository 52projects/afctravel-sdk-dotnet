using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Payment {
        public decimal Applied { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Notes { get; set; }
        public string Payor { get; set; }
        public string Type { get; set; }
    }
}
