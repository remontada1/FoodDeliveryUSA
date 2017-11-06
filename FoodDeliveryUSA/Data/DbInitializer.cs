using System.Linq;
using FoodDeliveryUSA.Models;

namespace FoodDeliveryUSA.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FoodDeliveryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                return;
            }

            var customers = new []
            {
            new Customer{FirstName = "Artur", LastName = "Bilzaryan", Email = "ArBil@gmail.com", PhoneNumber = "+170070000"}
            };
            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();
        }
    }
}