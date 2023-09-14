using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllOrders")]
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        [HttpGet("GetOrder")]
        public Order GetOrder(int orderId)
        {
            return _orderService.GetOrder(orderId);
        }

        [HttpPost("AddOrder")]
        public IActionResult AddOrder([FromBody] Order order)
        {
            _orderService.AddOrder(order);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteOrder")]
        public IActionResult DeleteOrder(int orderId)
        {
            _orderService.DeleteOrder(orderId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateOrder")]
        public IActionResult UpdateOrder([FromBody] Order order)
        {
            _orderService.UpdateOrder(order);
            return Ok("Product updated successfully!!");
        }
    }
}

