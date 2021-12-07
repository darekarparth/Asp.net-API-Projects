using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class DummyData
    {
        public static DummyData Current { get; } = new DummyData();

        public List<ProductDto> Products { get; set; }

        public DummyData()
        {
            Products = new List<ProductDto>()
            {
                new ProductDto()
                {
                    Id = 1,
                    Name = "Mixer",
                    Price=1000
                },

                  new ProductDto()
                {
                    Id = 2,
                    Name = "Grinder",
                    Price=1200
                },
                    new ProductDto()
                {
                    Id = 3,
                    Name = "Juicer",
                    Price=1400
                },
                   new ProductDto()
                {
                    Id = 4,
                    Name = "Hair Dryer",
                    Price=1600
                },
                   new ProductDto()
                {
                    Id = 5,
                    Name = "Tv",
                    Price=1800
                },
                  new ProductDto()
                {
                    Id = 6,
                    Name = "Fridge",
                    Price=2000
                },
                   

            };
        }
    }
}
