namespace Assignment_4_WebApplication.Models
{
    public class Results
    {
        public Result[] results { get; set; }
    }

    public class Result
    {
        public object state_id { get; set; }
        public string state_abbr { get; set; }
        public int year { get; set; }
        public int population { get; set; }
        public int violent_crime { get; set; }
        public int homicide { get; set; }
        public int? rape_legacy { get; set; }
        public int? rape_revised { get; set; }
        public int robbery { get; set; }
        public int aggravated_assault { get; set; }
        public int property_crime { get; set; }
        public int burglary { get; set; }
        public int larceny { get; set; }
        public int motor_vehicle_theft { get; set; }
        public int arson { get; set; }
    }
}
