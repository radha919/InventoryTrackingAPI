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
    public class OrderLineRepository : IOrderLineRepository
    {
        InventoryDbcontext _dbcontext;

        public OrderLineRepository(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddOrderLine(OrderLineItem orderline)
        {
            _dbcontext.OrdersLineItem.Add(orderline);
            _dbcontext.SaveChanges();
        }

        public void DeleteOrderLine(int orderlineId)
        {
            var orderLine = _dbcontext.OrdersLineItem.Find(orderlineId);
            _dbcontext.OrdersLineItem.Remove(orderLine);
            _dbcontext.SaveChanges();
        }

        public OrderLineItem GetOrderLine(int orderlineId)
        {
            return _dbcontext.OrdersLineItem.Find(orderlineId);
        }

        public IEnumerable<OrderLineItem> GetAllOrdersLine()
        {
            return _dbcontext.OrdersLineItem.ToList();
        }

        public void UpdateOrderLine(OrderLineItem orderLine)
        {
            _dbcontext.Entry(orderLine).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }

        
    }
}

