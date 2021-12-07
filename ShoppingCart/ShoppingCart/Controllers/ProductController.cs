using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;
using ShoppingCart.Models;
using ShoppingCart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{

    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        //    [HttpGet]
        //    public IActionResult GetProducts()
        //    {
        //        return Ok(DummyData.Current.Products);
        //    }

        //    [HttpGet("{Id}")]
        //    public IActionResult GetSingleProducts(int Id)
        //    {
        //        var ProductToReturn = DummyData.Current.Products.FirstOrDefault(c => c.Id == Id);
        //        return Ok(ProductToReturn);
        //    }

        //    [HttpPost("create")]
        //    public IActionResult PostProducts([FromBody] ProductDto Products)
        //    {
        //        var FinalProduct = new ProductDto()
        //        {
        //            Id = Products.Id,
        //            Name = Products.Name,
        //            Price = Products.Price

        //        };
        //        DummyData.Current.Products.Add(FinalProduct);
        //        return Ok(FinalProduct);
        //    }

        //    [HttpDelete("{Id}")]

        //    public IActionResult DeleteProduct(int Id)
        //    {
        //        var ProductToDelete = DummyData.Current.Products.FirstOrDefault(c => c.Id == Id);
        //        DummyData.Current.Products.Remove(ProductToDelete);
        //        return Ok("Product Deleted Successfully");
        //    }

        //----------------------------------------------------------------------------------------------------------------------------
        private readonly IProductRepository _productrepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productrepository, IMapper mapper) //constructor
        {
         _productrepository=productrepository ??
              throw new ArgumentNullException(nameof(_productrepository));
        _mapper = mapper ??
                   throw new ArgumentNullException(nameof(mapper));

        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var productentities = _productrepository.GetProducts();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productentities));
        }


        [HttpGet("{Id}")]
        public IActionResult GetSingleProducts(int Id)
        {
            var product = _productrepository.GetSingleProduct(Id);
            return Ok(_mapper.Map<ProductDto>(product));
        }

       
        
        [HttpPost]
        public IActionResult AddProduct(ProductDto productDto)
        {
            var Addproduct = _mapper.Map<Entities.Product>(productDto);
            _productrepository.AddProduct(Addproduct);
            _productrepository.Save();

            return Ok(Addproduct);
        }
    }
}
