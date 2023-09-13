using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inventory.BAL.Services;
using Inventory.EAL.Models;

namespace InventoryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllProduct")]
        public IEnumerable<Product> GetAllProduct()
        {
            return _productService.GetAllProduct();
        }
        [HttpGet("GetProduct")]
        public Product GetProduct(int productId)
        {
            return _productService.GetProduct(productId);
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok("Product created successfully!!");
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int productId)
        {
            _productService.DeleteProduct(productId);
            return Ok("Product deleted successfully!!");
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productService.UpdateProduct(product);
            return Ok("Product updated successfully!!");
        }
    }
}
