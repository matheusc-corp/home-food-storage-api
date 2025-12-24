using home_food_storage_api.Context;
using home_food_storage_api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace home_food_storage_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : Controller
    {
        private readonly PurchaseContext _context;

        public PurchaseController(PurchaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreatePurchase([FromBody] PurchaseModel purchase)
        {
            purchase.PurchaseCreateDate = DateTime.Now;
            purchase.PurchaseUpdateDate = DateTime.Now;
            
            _context.Purchases.Add(purchase);
            _context.SaveChanges();

            return Created("", purchase);
        }

        [HttpPut("/{id}")]
        public IActionResult EditPurchase([FromRoute] int id, [FromBody] PurchaseModel purchase)
        {
            var foundPurchase = _context.Purchases.FirstOrDefault(x => x.PurchaseId == id);

            if (foundPurchase != null)
            {
                return NotFound();
            }

            foundPurchase.PurchaseUpdateDate = purchase.PurchaseUpdateDate;
            foundPurchase.PurchasePlace = purchase.PurchasePlace;
            foundPurchase.PurchasePlaceCity = purchase.PurchasePlaceCity;
            foundPurchase.PurchasePaymentMethod = purchase.PurchasePaymentMethod;
            
            _context.Purchases.Update(foundPurchase);
            _context.SaveChanges();

            return Ok(foundPurchase);
        }

        [HttpDelete("/{id}")]
        public IActionResult DeletePurchase([FromRoute] int id)
        {
            var foundPurchase = _context.Purchases.FirstOrDefault(x => x.PurchaseId == id);

            if (foundPurchase != null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(foundPurchase);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("/{id}")]
        public IActionResult ReturnOne([FromRoute] int id)
        {
            var foundPurchase = _context.Purchases.FirstOrDefault(x => x.PurchaseId == id);

            if (foundPurchase != null)
            {
                return NotFound();
            }

            return Ok(foundPurchase);
        }

    }
}
