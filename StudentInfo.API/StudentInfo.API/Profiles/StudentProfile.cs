using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Profiles
{
    public class StudentProfile :Profile
    {
        public StudentProfile()  
        {
            CreateMap<Entities.Student, Models.StudentDto>();
            CreateMap<Models.StudentCreationDto, Entities.Student>();
            CreateMap<Models.StudentUpdationDto, Entities.Student>();
            CreateMap<Entities.Student, Models.StudentUpdationDto >();

        }
    }
}
