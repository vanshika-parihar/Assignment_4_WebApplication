
namespace Assignment_4_WebApplication.Models
{
    public class Results
    {
        public Result[] results { get; set; }
    }
    public class Result
    {
        public int data_year { get; set; }
        public int population { get; set; }
        public int total_agency_count { get; set; }
        public int published_agency_count { get; set; }
        public int active_agency_count { get; set; }
        public int covered_agency_count { get; set; }
        public int population_covered { get; set; }
        public int agency_count_nibrs_submitting { get; set; }
        public int agency_count_leoka_submitting { get; set; }//(LEOKA) Law Enforcement Officers Killed and Assaulted 
        public int agency_count_pe_submitting { get; set; }// pe - police employees
        public int agency_count_srs_submitting { get; set; }// srs - Summary Reporting System
        public int agency_count_asr_submitting { get; set; } //asr -AGE, SEX, AND RACE
        public int agency_count_hc_submitting { get; set; }//hc - Hate Crime
        public int agency_count_supp_submitting { get; set; }
        public int nibrs_population_covered { get; set; }
        public int total_population { get; set; }
        public float nibrs_population_percentage_covered { get; set; }//nibrs - National Incident-Based Reporting System
        public string csv_header { get; set; }
    }
}
