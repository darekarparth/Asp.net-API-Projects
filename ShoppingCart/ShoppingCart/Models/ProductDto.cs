using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
        
        public int Quantity { get; set; }

      //  public ICollection<CartDto> Carts { get; set; }
      //= new List<CartDto>();//ICollection is a type of List.
    }
}
