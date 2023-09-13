using Inventory.EAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Data
{
    public class InventoryDbcontext:DbContext
    {
        internal readonly object Customer;

        public InventoryDbcontext(DbContextOptions<InventoryDbcontext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Purchase> Purchases { get; set;}
        public DbSet<PurchaseLineItem> PurchasesLineItem { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLineItem> OrdersLineItem { get; set;}

        public DbSet<SalesOrderr> SalesOrders { get; set; }
        public DbSet<SalesOrderLineItem> SalesOrdersLineItem { get; set;}

        public DbSet<Customer> Customers { get; set; }
    }
}
