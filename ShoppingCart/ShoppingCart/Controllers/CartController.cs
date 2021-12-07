using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingCart.Models;
using ShoppingCart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{

    [ApiController]//This is attribute 
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly ILogger<CartController> _logger;
        private readonly IProductRepository _productrepository;
        private readonly IMapper _mapper;


        public CartController (ILogger<CartController> logger, IProductRepository productRepository, IMapper mapper)
        {
            _logger= logger ?? throw new ArgumentNullException(nameof(logger));
            _productrepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        } 
        
        
        [HttpGet]
        public IActionResult GetCart()
        {
            var cart = _productrepository.GetCart();
            return Ok(_mapper.Map<IEnumerable<CartDto>>(cart));
        }


        [HttpGet("{Id}")]
        public IActionResult GetSingleProductFromCart(int Id)
        {
            var cart = _productrepository.GetSingleProductFromCart(Id);
            return Ok(_mapper.Map<CartDto>(cart));
        }


        [HttpPost]
        public IActionResult EnterIntoProduct(CartDto cartDto ) 
        {
            var cartproduct = _mapper.Map<Entities.Cart>(cartDto);
            _productrepository.EnterIntoCart(cartproduct);
            _productrepository.Save();

            return Ok(cartproduct);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateFromCart(int Id, CartDto cartdto)
        {

            var cartproduct = _productrepository.GetSingleProductFromCart(Id);
            _mapper.Map(cartdto, cartproduct);
            //cartproduct.CartId = cartdto.CartId;
            //cartproduct.Id = cartdto.Id;
            //cartproduct.Name = cartdto.Name;
            //cartproduct.Price = (cartdto.Price * cartdto.Quantity);
            //cartproduct.Quantity = cartdto.Quantity;
            
            _productrepository.UpdateCart(cartproduct);
            _productrepository.Save();
            return Ok("Product updated");
        }





        [HttpDelete("{Id}")]
        public IActionResult DeleteProductFromCart(int Id)
        {

            var cartproduct = _productrepository.GetSingleProductFromCart(Id);
            _productrepository.DeleteProductFromCart(cartproduct);
            _productrepository.Save();
            return Ok("Product deleted from Cart");
        }

    }
}
