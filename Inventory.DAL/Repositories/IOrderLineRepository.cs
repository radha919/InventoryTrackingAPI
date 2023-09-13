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
         

        public void AddOrderLine(OrderLineItem orderline);

        public void UpdateOrderLine(OrderLineItem orderline);

        public void DeleteOrderLine(int id);

        public OrderLineItem GetOrderLine(int id);

        IEnumerable<OrderLineItem> GetAllOrdersLine();
    }
}
