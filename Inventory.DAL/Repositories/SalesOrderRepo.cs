using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{

    public class SalesOrder : ISalesOrder
    {
        public int OrderId { get; private set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; private set; }

        public SalesOrder(int orderId, DateTime orderDate, string customerName)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            CustomerName = customerName;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var product in Products)
            {
                totalAmount += product.Price;
            }
            return totalAmount;
        }

        public decimal TotalAmount => CalculateTotalAmount();
    }
}
