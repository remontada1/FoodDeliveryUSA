using System.Collections.Generic;
using System.Linq;
using FoodDeliveryUSA.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryUSA.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly FoodDeliveryContext context;

        public CustomerController(FoodDeliveryContext context)
        {
            
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = context.Customers.FirstOrDefault(i => i.Id == id);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            return new ObjectResult(customer);
        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody]Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            context.Customers.Add(customer);
            context.SaveChanges();

            return Ok("Customer created");
        }
    }
}