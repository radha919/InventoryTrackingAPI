using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
        [HttpGet("GetCustomer")]
        public Customer GetCustomer(int customerId)
        {
            return _customerService.GetCustomer(customerId);
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int customerId)
        {
            _customerService.DeleteCustomer(customerId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Product updated successfully!!");
        }
    }
}

