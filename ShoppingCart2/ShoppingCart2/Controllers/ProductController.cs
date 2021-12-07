using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart2.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(DummyData.Current.Products);
        }


        [HttpGet("{Id}")]
        public IActionResult GetSingleProduct(int Id)
        {
            var ProductToReturn= DummyData.Current.Products.FirstOrDefault(c => c.Id == Id);
            return Ok(ProductToReturn);
        }




    }



}
