using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AFCTravel.Api.Models {
    public class Trip {
        public Trip() {
            this.Attachments = new List<Attachment>();
            this.Miscy = new List<Models.Miscy>();
            this.Payments = new List<Payment>();
            this.Quotes = new List<Quote>();
            this.PNRS = new List<PNRLookup>();
        }
        public int ID { get; set; }
        public Agent Agent { get; set; }
        public List<Attachment> Attachments { get; set; }
        public Brand Brand { get; set; }
        public string CityPairs { get; set; }
        public Client Client { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Group Group { get; set; }
        public string InternalNotes { get; set; }
        public bool Locked { get; set; }
        public List<Miscy> Miscy { get; set; }
        public string Name { get; set; }
        public int? NumberOfPassengers { get; set; }
        public List<Payment> Payments { get; set; }
        public string Progress { get; set; }
        public List<Quote> Quotes { get; set; }
        public List<Signature> Signatures { get; set; }
        [JsonProperty("pnrs")]
        public List<PNRLookup> PNRS { get; set; }
        public string Status { get; set; }
        public DateTime TravelFromDate { get; set; }
        public DateTime TravelToDate { get; set; }
        public int TripID { get; set; }
        public string TripIDFormatted {get; set; }
        public string ValidatingCarriers { get; set; }
    }

}
