using DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities.Context
{
    public class SmsContext : DbContext
    {
        public SmsContext(DbContextOptions<SmsContext> options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem>  CartItems  { get; set; }
        public DbSet<Order>  Orders { get; set; }
        public DbSet<OrderItem> OrderItems{ get; set; }
        public DbSet<Payment> Payments { get; set; }


    }
}
