using ShoppingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetSingleProduct(int id);
        void AddProduct(Product product);
  
        //---------------------------------------------------------------------------------------------
        
        IEnumerable<Cart> GetCart();

        Cart GetSingleProductFromCart(int Id);
        void EnterIntoCart(Cart cart);
        void DeleteProductFromCart(Cart cart);

        void UpdateCart(Cart cart);
        //bool ProductExists(int id);
        //void AddProduct(Student student);
        //void UpdateProduct(Student student);

        bool Save();
    }
}
