using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoachAPI.Models
{
    public class WorkoutType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Exercise Exercise { get; set; }
    }
}
