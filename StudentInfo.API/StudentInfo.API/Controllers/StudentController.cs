using Microsoft.AspNetCore.Mvc;
using StudentInfo.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Logging;
//using StudentInfo.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentInfo.API.Services;
using AutoMapper;


namespace StudentInfo.API.Controllers
{

    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase //  Controller 
    {
        //[HttpGet]
        //public IActionResult GetStudents()

        //{
        //    return Ok(StudentDataStore.Current.Students);//return us 200 ok request with data in postman.
        //}

        //[HttpGet("{id}", Name = "GetStudent")]//Attribute and code for returning single city
        //public IActionResult GetSingleStudent(int id) //Using IActionResult instead of JsonResult is that,results arent necessarily returned in JSON format.// it works Like JsonResult class/datatype  only.
        //{
        //    //find city
        //    var StudentToReturn = StudentDataStore.Current.Students.FirstOrDefault(c => c.Id == id);
        //    if (StudentToReturn == null)
        //    {
        //        return NotFound(); //returns us 404 not found request 
        //    }
        //    return Ok(StudentToReturn);//return us 200 ok request with data in postman
        //}


        //[HttpPost("create")]
        //public IActionResult CreatStudents([FromBody] StudentCreationDto studentCreation)
        //{

        //    var finalStudent = new StudentDto()
        //    {
        //        Id = studentCreation.Id,
        //        First_Name = studentCreation.First_Name,
        //        Last_Name = studentCreation.Last_Name,
        //        City = studentCreation.City,
        //        Phone = studentCreation.Phone,
        //    };


        //   StudentDataStore.Current.Students.Add(finalStudent);
        //   return Ok(finalStudent);
        //}


        //[HttpPut("{id}")]
        //public IActionResult UpdateStudent(int id, [FromBody] StudentCreationDto studentCreation)
        //{
        //    var student = StudentDataStore.Current.Students.FirstOrDefault(c => c.Id == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    student.Id = studentCreation.Id;
        //    student.First_Name = studentCreation.First_Name;
        //    student.Last_Name = studentCreation.Last_Name;
        //    student.City = studentCreation.City;
        //    student.Phone = studentCreation.Phone;
        //    return NoContent();
        //}

        //[HttpPatch("{id}")]
        //public IActionResult PatchStudent(int id, JsonPatchDocument<StudentUpdationDto> patchDoc)
        //{
        //    var student =StudentDataStore.Current.Students
        //    .FirstOrDefault(c => c.Id == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }



        //    var StudentToPatch = new StudentUpdationDto()
        //           {
        //               Id=student.Id,
        //               First_Name = student.First_Name,
        //               Last_Name =  student.Last_Name,
        //               City=student.City,
        //               Phone=student.Phone
        //           };

        //    patchDoc.ApplyTo(StudentToPatch, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }



        //    if (!TryValidateModel(StudentToPatch))
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    student.Id = StudentToPatch.Id;
        //    student.First_Name = StudentToPatch.First_Name;
        //    student.Last_Name = StudentToPatch.Last_Name;
        //    student.City = StudentToPatch.City;
        //    student.Phone = StudentToPatch.Phone;
        //    return NoContent();

        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteStudent( int id)
        //{
        //    var student = StudentDataStore.Current.Students.FirstOrDefault(c => c.Id == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    StudentDataStore.Current.Students.Remove(student);
        //    return NoContent();

        //}

        //}

        //}

        //----------------------------------------------------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private readonly IStudentInfoRepository _studentInfoRepository;
        private readonly IMapper _mapper;


        public StudentController(IStudentInfoRepository studentInfoRepository, IMapper mapper)//constructor. we inject IMapper 
        {
            _studentInfoRepository = studentInfoRepository ??
              throw new ArgumentNullException(nameof(_studentInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));//initializes a new instance of ArgumentNullException class with name of parameter that causes this exception.
        }

     

        [HttpGet]
        public IActionResult GetStudents()

        {
            var studentEntities = _studentInfoRepository.GetStudents();

            //var results = new List<StudentDto>(); //Manual Mapping

            //foreach (var studentEntity in studentEntities)
            //{
            //    results.Add(
            //    new StudentDto
            //    {
            //        Id = studentEntity.Id,
            //        First_Name = studentEntity.First_Name,
            //        Last_Name = studentEntity.Last_Name,
            //        City=studentEntity.City,
            //        Phone=studentEntity.Phone
            //    });
            //}
            //return Ok(results);
             return Ok(_mapper.Map<IEnumerable<StudentDto>>(studentEntities));
          
           
        }

     
        
        [HttpGet("{id}")]//Attribute and code for returning single city
        public IActionResult GetSingleStudent(int id) //Using IActionResult instead of JsonResult is that,results arent necessarily returned in JSON format.// it works Like JsonResult class/datatype  only.
        {
            //find city
            var Student = _studentInfoRepository.GetSingleStudent(id);
            if (Student == null)
            {
                return NotFound(); //returns us 404 not found request 
            }
            return Ok(_mapper.Map<StudentDto>(Student));//return us 200 ok request with data in postman
            //return View();
        }


        [HttpPost("create")]
        public IActionResult CreatStudents([FromBody] StudentCreationDto studentCreation)
        {

            //var finalStudent = new StudentDto()
            //{
            //    Id = studentCreation.Id,
            //    First_Name = studentCreation.First_Name,
            //    Last_Name = studentCreation.Last_Name,
            //    City = studentCreation.City,
            //    Phone = studentCreation.Phone,
            //};

            var finalStudent = _mapper.Map<Entities.Student>(studentCreation);
            //StudentDataStore.Current.Students.Add(finalStudent);
            
            _studentInfoRepository.AddStudent(finalStudent);
            _studentInfoRepository.Save();
            var StudentToReturn = _mapper
               .Map<Models.StudentDto>(finalStudent);

            //return CreatedAtRoute(
            //   "GetStudent",
            //   new { id = StudentToReturn.Id },
            //    StudentToReturn);

            return Ok(finalStudent);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentUpdationDto studentUpdation)
        {
            if (!_studentInfoRepository.StudentExists(id))
            {
                return NotFound();
            }
            
            var studentEntity = _studentInfoRepository.GetSingleStudent(id);
            if (studentEntity == null)
            {
                return NotFound();
            }
            _mapper.Map(studentUpdation, studentEntity);
            _studentInfoRepository.UpdateStudent(studentEntity);
            _studentInfoRepository.Save();
            return NoContent();
        }





        [HttpPatch("{id}")]
        public IActionResult PatchStudent(int id, JsonPatchDocument<StudentUpdationDto> patchDoc)
        {

            if (!_studentInfoRepository.StudentExists(id))
            {
                return NotFound();
            }

            var studentEntity = _studentInfoRepository
                .GetSingleStudent(id);
            if (studentEntity == null)
            {
                return NotFound();
            }


            var StudentToPatch = _mapper.Map<StudentUpdationDto>(studentEntity);

            patchDoc.ApplyTo(StudentToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            if (!TryValidateModel(StudentToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(StudentToPatch, studentEntity);
            _studentInfoRepository.UpdateStudent(studentEntity);
            _studentInfoRepository.Save();

            return NoContent();

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (!_studentInfoRepository.StudentExists(id))
            {
                return NotFound();
            }

            var studentEntity = _studentInfoRepository
                .GetSingleStudent(id);
            if (studentEntity == null)
            {
                return NotFound();
            }


            _studentInfoRepository.DeleteStudent(studentEntity);
            _studentInfoRepository.Save();

            return NoContent();

        }

        //public ViewResult List()
        //{
        //    return View();
        //}

       
    }
}
