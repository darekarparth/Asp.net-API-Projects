using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API.Entity
{
    public class PointOfInterest
    {
        [Key]//Attribute //Data annotation(regarded as Primary key )
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// the new key will be generated when the city is added.
        public int Id { get; set; }

        [Required] //Validation annotations
        [MaxLength(50)]// Validation annotations
        public string Name { get; set; }

        //[MaxLength(200)]
        //public string Description { get; set; }


        [ForeignKey("CityId")] //foreign key is Class name "City" followed by "Id".
        public City City { get; set; } // we want to be able to navigate through our object graph from PointofInterest to the Parent City.// So this property refer to that parent city.

        public int CityId { get; set; } //Foreign key , Class name City followed by Id that is CityId //For navigation Property City, the foreign key on PoinyOfinterest is named "CityId".   
    }
}
