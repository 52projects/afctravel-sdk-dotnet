using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace AFCTravel.Api.Models {
    public class PNRLookup {
        public int PnrId { get; set; }
        public string RecordLocator { get; set; }
        public string AccessCode { get; set; }
    }
}
