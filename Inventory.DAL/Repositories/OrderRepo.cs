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
    public class OrderRepo: IOrderRepo
    {
        InventoryDbcontext _dbcontext;

        public OrderRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddOrder(Order order)
        {
            _dbcontext.Orders.Add(order);
            _dbcontext.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = _dbcontext.Orders.Find(orderId);
            _dbcontext.Orders.Remove(order);
            _dbcontext.SaveChanges();
        }

        public Order GetOrder(int orderId)
        {
            return _dbcontext.Orders.Find(orderId);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _dbcontext.Orders.ToList();
        }

        public void UpdateOrder(Order order)
        {
            _dbcontext.Entry(order).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
