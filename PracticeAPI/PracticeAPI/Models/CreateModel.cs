using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Models
{
    public class CreateModel
    {
        [Required(ErrorMessage = "You should provide a name value.")]//data annotation attribute for validations, if invalid  name value or Description greater than 50,200 letters is entered in Body(Postman), then it will return error 400 bad request.


        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public int age { get; set; }
    }
}
