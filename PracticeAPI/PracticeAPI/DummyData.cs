using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI
{
    public class DummyData
    {
        public static DummyData Current { get; } = new DummyData(); //Created a new object of class DummyData.

        public List<MainModel> InputData { get; set; } // we created a list named InputData.

        public DummyData()//Constructor
        {
            InputData = new List<MainModel>()
            {
                new MainModel()
                {
                    Id=1,
                    Name="Parth",
                    age=23
                   
                },

                new MainModel()
                {
                     Id=2,
                     Name="Nupur",
                     age=27
                },

                new MainModel()
                {
                    Id=3,
                    Name="Nachiket",
                    age=22
                },

                new MainModel()
                {
                    Id=4,
                    Name="Mihir",
                    age=24


                }



            };
        }
    }
}
