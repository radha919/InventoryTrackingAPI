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
    public class SalesOrderrController : ControllerBase
    {
        private SalesService _salesOrderService;
        public SalesOrderrController(SalesService salesOrderService)
        {
            _salesOrderService = salesOrderService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllSales")]
        public IEnumerable<SalesOrderr> GetAllSales()
        {
            return _salesOrderService.GetAllSales();
        }
        [HttpGet("GetSales")]
        public SalesOrderr GetSales(int salesId)
        {
            return _salesOrderService.GetSales(salesId);
        }

        [HttpPost("AddSales")]
        public IActionResult AddSales([FromBody] SalesOrderr salesOrderr)
        {
            _salesOrderService.AddSales(salesOrderr);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteSales")]
        public IActionResult DeleteSales(int salesId)
        {
            _salesOrderService.DeleteSales(salesId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateSales")]
        public IActionResult UpdateSales([FromBody] SalesOrderr salesOrderr)
        {
            _salesOrderService.UpdateSales(salesOrderr);
            return Ok("Product updated successfully!!");
        }
    }
}

