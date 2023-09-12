using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface IOrderLineRepository
    {
        IEnumerable<OrderLineItem> GetAllOrderLines() ;
        OrderLineItem GetOrderLineById(int orderLineId);
        void AddOrderLine(OrderLineItem orderLine);
        void UpdateOrderLine(OrderLineItem orderLine);
        void DeleteOrderLine(int orderLineId);
        void SaveChanges();
    }
}
