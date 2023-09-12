using Inventory.DAL.Data;
using Inventory.EAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly InventoryDbcontext _inventoryDbContext;

        public ProductRepo(InventoryDbcontext inventoryDbContext)
        {
            _inventoryDbContext = inventoryDbContext;
        }

        public void AddProduct(Product product)
        {
            _inventoryDbContext.Product.Add(product);
            _inventoryDbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _inventoryDbContext.Entry(product).State = EntityState.Modified;
            _inventoryDbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _inventoryDbContext.Product.Find(id);
            if (product != null)
            {
                _inventoryDbContext.Product.Remove(product);
                _inventoryDbContext.SaveChanges();
            }
        }

        public Product? GetProduct(int id)
        {
            return _inventoryDbContext.Product.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            return _inventoryDbContext.Product.ToList();
        }
    }
}
