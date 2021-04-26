using Assignment_4_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.Configuration;

namespace Assignment_4_WebApplication.DataAccess
{
    public class ApplicatonDbContext : DbContext
    {
        public ApplicatonDbContext(DbContextOptions options) : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<Incident> Reviews { get; set; }

        public static string GetConnectionString()
        {
            string constring = @"Server=(localdb)\mssqllocaldb;Database=Incident_DB;Trusted_Connection=True;ConnectRetryCount=0";
            return constring;
        }
    }
}
