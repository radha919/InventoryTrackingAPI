using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLineItemController : ControllerBase
    {
        private OrderLineItemService _orderLineItemService;
        public OrderLineItemController(OrderLineItemService orderLineItemService)
        {
            _orderLineItemService = orderLineItemService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllOrdersLine")]
        public IEnumerable<OrderLineItem> GetAllOrdersLine()
        {
            return _orderLineItemService.GetAllOrdersLine();
        }
        [HttpGet("GetOrderLine")]
        public OrderLineItem GetOrderLine(int orderLineId)
        {
            return _orderLineItemService.GetOrderLine(orderLineId);
        }

        [HttpPost("AddOrderLine")]
        public IActionResult AddOrderLine([FromBody] OrderLineItem orderLineItem)
        {
            _orderLineItemService.AddOrderLine(orderLineItem);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteOrderLine")]
        public IActionResult DeleteOrderLine(int orderLineId)
        {
            _orderLineItemService.DeleteOrderLine(orderLineId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateOrderLine")]
        public IActionResult UpdatOrderLine([FromBody] OrderLineItem orderLineItem)
        {
            _orderLineItemService.UpdateOrderLine(orderLineItem);
            return Ok("Product updated successfully!!");
        }
    }
}
