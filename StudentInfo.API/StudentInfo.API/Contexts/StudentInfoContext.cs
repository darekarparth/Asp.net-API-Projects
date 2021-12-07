using Microsoft.EntityFrameworkCore;
using StudentInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Contexts
{
    public class StudentInfoContext : DbContext
    {
        public DbSet<Student> Students { get; set; } //DbSet can be used to query and save instances of its entity type, so link query  against the DbSet will be transated into query against the database.

        public StudentInfoContext(DbContextOptions<StudentInfoContext> options)//so we add a constructor that  calls  DbContext defination Constructor overload. //
          : base(options)
        {
              //Database.EnsureCreated(); //for this method to work we add DummyController simply to test this. //
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//we override method OnModelCreating(ModelBuilder modelBuilder),Doing so gives us access to the model builder/ It is used to provide data for seeding the database. //Dummy data
        {
            modelBuilder.Entity<Student>()
                 .HasData(  //this method is used to provide data for students.
                new Student()
                {
                    Id = 1,
                    First_Name = "Parth",
                    Last_Name = "Darekar",
                    City = "Pune",
                    Phone = 9876543210

                },
                new Student()
                {
                    Id = 2,
                    First_Name = "Nupur",
                    Last_Name = "Darekar",
                    City = "Satara",
                    Phone = 76543234567
                },
                new Student()
                {
                    Id = 3,
                    First_Name = "Nachiket",
                    Last_Name = "Joshi",
                    City = "Kolhapur",
                    Phone = 1234567890
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}

//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //there is a methode here we can override, Onconfiguring. This methode has an optionsBuilder as parameter and that optionsBuilder provides us a method, UseSqlServer. 
//{
//    optionsBuilder.UseSqlServer("connectionstring"); //this tells the DbContext, its being used to connect to SQl server database,  and there we provide a connection string
//    base.OnConfiguring(optionsBuilder);// 
//}

//Our applicaton will use this context, so we need to register it  so its available  for dependancy Injection, in Startup.cs.  