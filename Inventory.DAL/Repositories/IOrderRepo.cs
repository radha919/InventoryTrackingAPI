using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{



    public interface IOrderRepo
    {
        public void AddOrder(Order order);

        public void UpdateOrder(Order order);

        public void DeleteOrder(int id);

        public Order GetOrder(int id);

        IEnumerable<Order> GetAllOrders();
    }
    }
    
