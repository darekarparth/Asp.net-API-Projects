using ShoppingCart.Data;
using ShoppingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        
        public ProductRepository(Context context)
        {
            _context=context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.ProductTable.OrderBy(c => c.Id).ToList();
        }

        public Product GetSingleProduct(int Id)
        {
            return _context.ProductTable.Where(c => c.Id == Id).FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            _context.ProductTable.Add(product);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        public IEnumerable<Cart> GetCart()
        {
            return _context.CartTable.OrderBy(c => c.ProductId).ToList();
        }

       public void EnterIntoCart(Cart cart)
        {
            _context.CartTable.Add(cart);
        }

        public Cart GetSingleProductFromCart(int Id)
        {
            return _context.CartTable.Where(c => c.CartId == Id).FirstOrDefault();
        }

        public void DeleteProductFromCart(Cart cart)
        {
            _context.CartTable.Remove(cart);
        }

        public void UpdateCart(Cart cart)
        {
           
        }
    }
}
