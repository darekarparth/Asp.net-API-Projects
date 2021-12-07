using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//annotation //the new key will be generated when the city is added.
        public int Id { get; set; }

        [Required] //Validation annotations
        [MaxLength(50)]// Validation annotations
        public string First_Name { get; set; }

        [Required] //Validation annotations
        [MaxLength(50)]// Validation annotations
        public string Last_Name { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string City { get; set; }

        [Required]
        public long Phone { get; set; }


    }
}
