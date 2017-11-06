using System;
using FoodDeliveryUSA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodDeliveryUSA
{
    public class FoodDeliveryContext : DbContext
    {
        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options) : base(options)
        {
        }
  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        
    }
}