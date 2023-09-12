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
        private readonly InventoryDbcontext _context;

        public OrderLineRepository(InventoryDbcontext context)
        {
            _context = context;
        }

        public void AddOrderLine(OrderLineItem orderLine)
        {
            _context.OrdersLineItem.Add(orderLine);
            _context.SaveChanges();
        }

        public void DeleteOrderLine(int orderLineId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderLineItem> GetAllOrderLines()
        {
            throw new NotImplementedException();
        }

        public OrderLineItem GetOrderLineById(int orderLineId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderLine(OrderLineItem orderLine)
        {
            throw new NotImplementedException();
        }
    }
}
