using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AFCTravel.Api.Models.Internal {
    public class InternalTrip {
        public InternalTrip() {
            Quotes = new List<Quote>();
            Brand = new Brand();
            Client = new Client();
        }
        public Brand Brand { get; set; }

        public Client Client { get; set; }

        public string Status { get; set; }

        public string TripType { get; set; }

        public string Progress { get; set; }

        [JsonProperty("travelFromDate")]
        public string TravelFromDateString {
            get {
                return TravelFromDate.ToString("yyy-MM-dd");
            }
            set {
                TravelFromDate = DateTime.Parse(value);
            }
        }

        [JsonProperty("travelToDate")]
        public string TravelToDateString {
            get {
                return TravelToDate.ToString("yyy-MM-dd");
            }
            set {
                TravelToDate = DateTime.Parse(value);
            }
        }

        [JsonIgnore]

        public DateTime TravelFromDate { get; set; }

        [JsonIgnore]
        
        public DateTime TravelToDate { get; set; }

        public string Name { get; set; }

        public string InternalNotes { get; set; }

        public List<Quote> Quotes { get; set; }
    }
}
