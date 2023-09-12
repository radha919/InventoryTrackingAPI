using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface ISalesOrder
    {
        int OrderId { get; }
        DateTime OrderDate { get; set; }
        string CustomerName { get; set; }
        decimal TotalAmount { get; }
        List<Product> Products { get; }

        void AddProduct(Product product);
        void RemoveProduct(Product product);
        decimal CalculateTotalAmount();
    }
}
