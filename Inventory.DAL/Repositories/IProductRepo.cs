using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
     
         
        public interface IProductRepo
        {
            public void AddProduct(Product product);

            public void UpdateProduct(Product product);

            public void DeleteProduct(int id);

            public Product? GetProduct(int id);

            public List<Product> GetAllProducts();
        }
    }


