
using Microsoft.EntityFrameworkCore;
using StateInfo.API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } //DbSet can be used to query and save instances of its entity type, so link query  against the DbSet will be transated into query against the database.
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        //(In DbContext defination:- We see a constructor here that gets a DbContext options instance injected.)
        public CityInfoContext(DbContextOptions<CityInfoContext> options)//so we add a constructor that  calls  DbContext defination Constructor overload. //
           : base(options)
        {
              //Database.EnsureCreated(); //for this method to work we add DummyController simply to test this. //
        }
    }
}
