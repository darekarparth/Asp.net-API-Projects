using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Product, Models.ProductDto>();
            CreateMap<Entities.Cart, Models.CartDto>();
            CreateMap<Models.ProductDto, Entities.Product>();
            CreateMap<Models.CartDto, Entities.Cart>();
            CreateMap<Models.CartCreationDto, Entities.Cart>();
        }
    }
}
