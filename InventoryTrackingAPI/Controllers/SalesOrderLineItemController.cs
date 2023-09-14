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
    public class SalesOrderLineItemController : ControllerBase
    {
        private SalesOrderService _salesOrderService;
        public SalesOrderLineItemController(SalesOrderService salesOrderService)
        {
            _salesOrderService = salesOrderService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllSalesOrder")]
        public IEnumerable<SalesOrderLineItem> GetAllSalesOrder()
        {
            return _salesOrderService.GetAllSalesOrder();
        }
        [HttpGet("GetSalesOrder")]
        public SalesOrderLineItem GetSalesOrder(int salesOrderId)
        {
            return _salesOrderService.GetSalesOrder(salesOrderId);
        }

        [HttpPost("AddSalesOrder")]
        public IActionResult AddSalesOrder([FromBody] SalesOrderLineItem salesOrderLine)
        {
            _salesOrderService.AddSalesOrder(salesOrderLine);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteSalesOrder")]
        public IActionResult DeleteSalesOrder(int salesOrderId)
        {
            _salesOrderService.DeleteSalesOrder(salesOrderId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateSalesOrder")]
        public IActionResult UpdateSalesOrder([FromBody] SalesOrderLineItem salesOrderLine)
        {
            _salesOrderService.UpdateSalesOrder(salesOrderLine);
            return Ok("Product updated successfully!!");
        }
    }
}

