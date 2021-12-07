//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Entities;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
          //Database.EnsureCreated();
        }
        public DbSet<Product> ProductTable { get; set; }
        public DbSet<Cart> CartTable { get; set; }
        public DbSet<ShoppingCart.Models.CartCreationDto> CartCreationDto { get; set; }

    }
}
