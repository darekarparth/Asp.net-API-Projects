using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Entities
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//annotation //the new key will be generated when the city is added.
        public int CartId { get; set; }


        //[Required]
        //public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("ProductId")] //foreign key is Class name "City" followe by "Id".
        public Product Product { get; set; } // we want to be able to navigate through our object graph from PointofInterest to the Parent City.// So this property refer to that parent city.

        public int ProductId { get; set; } //Foreign key , Class name City followed by Id that is CityId //For navigation Property City, the foreign key on PoinyOfinterest is named "CityId".    
    }
}
