using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_4_WebApplication.Models;
using Assignment_4_WebApplication.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Assignment_4_WebApplication.Controllers
{
    public class IncidentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Incidents()
        {
            var optionsBuilder = new DbContextOptionsBuilder();

            optionsBuilder.UseSqlServer(ApplicatonDbContext.GetConnectionString());
            using (var dbContext = new ApplicatonDbContext(optionsBuilder.Options))
            {
                var Incidents = dbContext.Reviews.ToList();
                var incidents = new Incidents();
                incidents.incidents = Incidents;
                return View(incidents);
            }
        }

        [HttpPost]
        public IActionResult DeleteIncident(int incident_id)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ApplicatonDbContext.GetConnectionString());
            using (var dbContext = new ApplicatonDbContext(optionsBuilder.Options))
            {
                var review = new Incident() { incident_id = incident_id };
                dbContext.Reviews.Remove(review);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Incidents");
        }

        [HttpPost]
        public IActionResult AddIncident(string name, int phone_number, string city, string address, string state, string relation, string description)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ApplicatonDbContext.GetConnectionString());
            using (var dbContext = new ApplicatonDbContext(optionsBuilder.Options))
            {
                var review = new Incident();
                review.name = name;
                review.phone_number = phone_number;
                review.city = city;
                review.address = address;
                review.state = state;
                review.relation = relation;
                review.description = description;

                //Adding to DB
                dbContext.Reviews.Add(review);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Incidents");
        }

    }
}

