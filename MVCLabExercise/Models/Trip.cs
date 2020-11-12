using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLabExercise.Models
{
    public class Trip
    {
        public double TripMiles{ get; set; }
        public double Gallons { get; set; }
        public double MPG { get; set; }
        public double Range { get; set; }
        public string Message { get; set; }
        public string Color { get; set; }

    }
}
