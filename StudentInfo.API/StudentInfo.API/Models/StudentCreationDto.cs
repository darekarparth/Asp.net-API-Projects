using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Models
{
    public class StudentCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]//data annotation attribute for validations, if invalid  name value or Description greater than 50,200 letters is entered in Body(Postman), then it will return error 400 bad request.
       
        
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }

        [MaxLength(50)]  // the error message for description in postman is Default error msg.
        public string City { get; set; }
        

        public long Phone { get; set; }

    }
}
