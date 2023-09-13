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
        InventoryDbcontext _dbcontext;

        public ProductRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddProduct(Product product)
        {
            _dbcontext.Products.Add(product);
            _dbcontext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbcontext.Products.Find(productId);
            _dbcontext.Products.Remove(product);
            _dbcontext.SaveChanges();
        }

        public Product GetProduct(int productId)
        {
            return _dbcontext.Products.Find(productId);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _dbcontext.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            _dbcontext.Entry(product).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
