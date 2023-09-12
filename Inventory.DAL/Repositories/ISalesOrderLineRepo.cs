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
        SalesOrderLineItem GetSalesOrderLineItem(int salesOrderId, int itemId);
        IEnumerable<SalesOrderLineItem> GetAllSalesOrderLineItems(int salesOrderId);
        void AddSalesOrderLineItem(SalesOrderLineItem lineItem);
        void UpdateSalesOrderLineItem(SalesOrderLineItem lineItem);
        void DeleteSalesOrderLineItem(int salesOrderId, int itemId);
    }
}
