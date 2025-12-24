using home_food_storage_api.Context;
using home_food_storage_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace home_food_storage_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private readonly PurchaseContext _context;

        public ItemController(PurchaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateItem([FromBody] ItemModel item)
        {
            return NoContent();
        }
    }
}
