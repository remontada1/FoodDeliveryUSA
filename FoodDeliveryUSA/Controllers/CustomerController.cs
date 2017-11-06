using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FoodDeliveryUSA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IEnumerable<Customer> GetFood()
        {
            return context.Customers.ToList();
        }
    }
}