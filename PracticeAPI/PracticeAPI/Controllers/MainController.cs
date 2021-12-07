using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("api/Main")]
    public class MainController : Controller
    {
        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(DummyData.Current.InputData);
            

//--------------------------------------------------------
            //MainModel Data1 = new MainModel();
            //Data1.Id = 1;
            //Data1.Name = "Parth";
            //Data1.age = 23;

            //MainModel Data2 = new MainModel();
            //Data1.Id = 2;
            //Data1.Name = "Nupur";
            //Data1.age = 27;

            //var data = new[] { Data1, Data2 }; //Array
            //return Ok(data);
//--------------------------------------------------------
            
            //var Totaldata = new List<MainModel>
            //{                new MainModel()
            //                 {
            //                    Id = 1,
            //                    Name = "Parth",
            //                    age = 23
            //                 },

            //                new MainModel()
            //                {
            //                     Id = 2,
            //                     Name = "Nupur",
            //                     age = 27
            //                },
            //};  
            //return Ok(Totaldata);

           }

    [HttpGet("{id}")]
        public IActionResult GetSingleData(int id)
        {
            var dataToReturn = DummyData.Current.InputData.FirstOrDefault(c => c.Id == id);
            if (dataToReturn == null)
            {
                return NotFound();

            }
            return Ok(dataToReturn);
        }

        [HttpPost("create")]
        public IActionResult CreateData([FromBody] CreateModel createmodel)
        {
            var finalData = new MainModel()
            {
                Id = createmodel.Id,
                Name = createmodel.Name,
                age = createmodel.age

            };
            DummyData.Current.InputData.Add(finalData);
            return Ok(finalData);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateData(int id, [FromBody] UpdateModel updatemodel)
        {
            var data = DummyData.Current.InputData.FirstOrDefault(c => c.Id == id);
            if (data == null)
            {
                return NotFound();
            }
            data.Id = updatemodel.Id;
            data.Name = updatemodel.Name;
            data.age = updatemodel.age;
            return Ok();

        }

        [HttpDelete("{id}")]
        
        public IActionResult DeleteData(int id)
        {
            var data = DummyData.Current.InputData.FirstOrDefault(c => c.Id == id);
            if (data == null)
            {
                return NotFound();
            }
            DummyData.Current.InputData.Remove(data);
            return Ok();
        }
        
    }
}
