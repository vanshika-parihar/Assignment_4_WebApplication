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

        public Microsoft.EntityFrameworkCore.DbSet<Incident> Incidents { get; set; }

        string connectionstring = "Server=(localdb)\\MSSQLLocalDB; Database=Incidents;Trusted_Connection=True;MultipleActiveResultSets=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }

        public static string GetConnectionString()
        {
            string connectionstring = @"Server=(localdb)\\MSSQLLocalDB; Database=Assignment_4_WebApplication;Trusted_Connection=True;ConnectRetryCount=0";
            return connectionstring;
        }

    }
}
