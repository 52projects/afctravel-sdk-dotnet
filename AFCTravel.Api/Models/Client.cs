using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Client {
        public string Address { get; set; }
        public string Arc { get; set; }
        public string Cac { get; set; }
        public string Cid { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }

        public string Name { get; set; }
        public string Organization { get; set; }
        public string Phone { get; set; }
    }
}
