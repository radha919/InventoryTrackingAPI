using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private PurchaseService _purchaseService;
        public PurchaseController(PurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllPurchase")]
        public IEnumerable<Purchase> GetAllPurchase()
        {
            return _purchaseService.GetAllPurchase();
        }
        [HttpGet("GetPurchase")]
        public Purchase GetPurchase(int purchaseId)
        {
            return _purchaseService.GetPurchase(purchaseId);
        }

        [HttpPost("AddPurchase")]
        public IActionResult AddPurchase([FromBody] Purchase purchase)
        {
            _purchaseService.AddPurchase(purchase);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeletePurchase")]
        public IActionResult DeletePurchase(int purchaseId)
        {
            _purchaseService.DeletePurchase(purchaseId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdatePurchase")]
        public IActionResult UpdatePurchase([FromBody] Purchase purchase)
        {
            _purchaseService.UpdatePurchase(purchase);
            return Ok("Product updated successfully!!");
        }
    }
}

