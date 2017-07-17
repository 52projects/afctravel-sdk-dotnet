using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Agent {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string TimeZone { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
    }
}
