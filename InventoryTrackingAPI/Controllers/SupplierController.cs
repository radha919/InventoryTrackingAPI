using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private SupplierService _supplierService;
        public SupplierController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllSupplier")]
        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _supplierService.GetAllSupplier();
        }
        [HttpGet("GetSupplier")]
        public Supplier GetSupplier(int supplierId)
        {
            return _supplierService.GetSupplier(supplierId);
        }

        [HttpPost("AddSupplier")]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            _supplierService.AddSupplier(supplier);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteSupplier")]
        public IActionResult DeleteSupplier(int supplierId)
        {
            _supplierService.DeleteSupplier(supplierId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateSupplier")]
        public IActionResult UpdateSupplier([FromBody] Supplier supplier)
        {
            _supplierService.UpdateSupplier(supplier);
            return Ok("Product updated successfully!!");
        }
    }
}


