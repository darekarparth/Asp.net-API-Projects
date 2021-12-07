using Microsoft.AspNetCore.Mvc;
using StudentInfo.API.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Controllers
{
 

        [ApiController]
        [Route("api/testdatabase")]
        public class DummyController : ControllerBase
        {
            private readonly StudentInfoContext _ctx;

            public DummyController(StudentInfoContext ctx) //instructor injection constructor.
            {
                _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));//this field ensures that once DummyController is constructed, an instance of StudentInfoContext is injected. which means CityInfoContext constructer is executed.
            }

            [HttpGet]
            public IActionResult TestDatabase()
            {
                return Ok();
            }
        }
    }




