using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Meal {
        public int MealId { get; set; }
        public int FlightId { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
    }
}
