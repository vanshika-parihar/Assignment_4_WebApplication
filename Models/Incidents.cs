using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_WebApplication.Models
{
    
    public class Incident
    {

        public object incident_id { get; set; }
        public string name { get; set; }
        public int     phone_number { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string relation { get; set; }
        public string description { get; set; }

    }
    public class Incidents
    {
        public List<Incident> incidents { get; set; }
    }

}
