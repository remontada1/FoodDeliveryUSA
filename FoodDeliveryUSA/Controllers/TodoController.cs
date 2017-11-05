using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryUSA.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        public IActionResult GetFood()
        {
            return Content("app created!!");
        }
    }
}