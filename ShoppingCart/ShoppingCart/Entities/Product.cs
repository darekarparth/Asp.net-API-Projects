using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//annotation //the new key will be generated when the city is added.
        public int Id { get; set; }

        [Required] //Validation annotations
        [MaxLength(50)]// Validation annotations
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

      //  public ICollection<Cart> Carts { get; set; }
      //= new List<Cart>();//ICollection is a type of List.
    }
}
