using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Signature {
        public DateTime DateCreated { get; set; }
        public DateTime? SignedAt { get; set; }
        public string Status { get; set; }
        public string ESignUrl { get; set; }
        public string SignedUrl { get; set; }
        public string ApiLabel { get; set; }
    }
}
