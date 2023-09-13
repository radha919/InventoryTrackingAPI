using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface ISalesOrderLineRepo
    {
         

        public void AddSalesOrder(SalesOrderLineItem salesOrder);

        public void UpdateSalesOrder(SalesOrderLineItem salesOrder);

        public void DeleteSalesOrder(int id);

        public SalesOrderLineItem GetSalesOrder(int id);

        IEnumerable<SalesOrderLineItem> GetAllSalesOrder();
    }
}
