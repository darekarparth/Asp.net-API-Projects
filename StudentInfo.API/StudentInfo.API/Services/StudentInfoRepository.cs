using StudentInfo.API.Contexts;
using StudentInfo.API.Entities;
using StudentInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Services
{
    public class StudentInfoRepository : IStudentInfoRepository //Data from IStudentInfoRepository  is inherited in StudentInfoRepository
    {

        private StudentInfoContext _context;
       

        public StudentInfoRepository(StudentInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));//initializes a new instance of ArgumentNullException class with name of parameter that causes this exception.
        }

       
        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.OrderBy(c => c.Id).ToList();//the Students returned are ordered by Id// ToList() ensures that thae query is executed at the specific time.
        }
    
        public Student GetSingleStudent(int id)
        {
            return _context.Students.Where(c => c.Id == id).FirstOrDefault(); //We return the city filtered by Id.
        }

        public bool StudentExists(int id)
        {
            return _context.Students.Any(c => c.Id == id);
        }

        public void AddStudent( Student student)//Student student is entity
        {
          
            _context.Students.Add(student); 
        }

        public void UpdateStudent(Student student)
        {
           
        }

        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }


}
