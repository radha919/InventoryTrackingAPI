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
    public class PurchaseLineItemController : ControllerBase
    {
        private  PurchaseLineItemService _purchaseLineItemService;
        public PurchaseLineItemController(PurchaseLineItemService purchaseLineItemService)
        {
            _purchaseLineItemService = purchaseLineItemService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllPurchaseLine")]
        public IEnumerable<PurchaseLineItem> GetAllPurchaseLine()
        {
            return _purchaseLineItemService.GetAllPurchaseLine();
        }
        [HttpGet("GetPurchaseLine")]
        public PurchaseLineItem GetPurchaseLIne(int purchaseLineId)
        {
            return _purchaseLineItemService.GetPurchaseLine(purchaseLineId);
        }

        [HttpPost("AddPurchaseLine")]
        public IActionResult AddPurchaseLine([FromBody] PurchaseLineItem purchaseLine)
        {
            _purchaseLineItemService.AddPurchaseLine(purchaseLine);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeletePurchaseLine")]
        public IActionResult DeletePurchaseLine(int purchaseLineId)
        {
            _purchaseLineItemService.DeletePurchaseLine(purchaseLineId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdatePurchaseLine")]
        public IActionResult UpdatePurchaseLine([FromBody] PurchaseLineItem purchaseLine)
        {
            _purchaseLineItemService.UpdatePurchaseLine(purchaseLine);
            return Ok("Product updated successfully!!");
        }
    }
}

