using StateInfo.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Entity
{
    public class City
    {
        [Key]//Attribute //Data annotation(regarded as Primary key )
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//annotation //the new key will be generated when the city is added.
        public int Id { get; set; }

        [Required] //Validation annotations
        [MaxLength(50)]// Validation annotations
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<PointOfInterest> PointsOfInterest { get; set; } //collection of Point of Interest
        = new List<PointOfInterest>();//ICollection is a type of List.
    }
}
