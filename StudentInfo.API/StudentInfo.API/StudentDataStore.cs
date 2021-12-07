using StudentInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API
{
    public class StudentDataStore
    {
        public static StudentDataStore Current { get; } = new StudentDataStore();

        public List<StudentDto> Students { get; set; }
        
        public StudentDataStore()//Constructor
        {
            Students = new List<StudentDto>()
            {
                new StudentDto()
                {
                    Id=1,
                    First_Name="Parth",
                    Last_Name="Darekar",
                    City="Pune",
                    Phone=9876543210
                },
                
                new StudentDto()
                {
                     Id=2,
                    First_Name="Nupur",
                    Last_Name="Darekar",
                    City="Satara",
                    Phone=76543234567
                },

                new StudentDto()
                {
                    Id=3,
                    First_Name="Nachiket",
                    Last_Name="Joshi",
                    City="Kolhapur",
                    Phone=1234567890

                },

                new StudentDto()
                {
                    Id=4,
                    First_Name="Mihir",
                    Last_Name="Muley",
                    City="Nashik",
                    Phone=9876789876

                }



            };
        }
    }
}
