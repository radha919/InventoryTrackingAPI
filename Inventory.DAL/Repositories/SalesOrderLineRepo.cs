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
    public class SalesOrderLineRepo : ISalesOrderLineRepo
    {
        private readonly InventoryDbcontext _dbContext;

        public SalesOrderLineRepo(InventoryDbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public SalesOrderLineItem GetSalesOrderLineItem(int salesOrderId, int itemId)
        {
            return _dbContext.SalesOrderLineRepo
                .FirstOrDefault(item => item.SalesOrderId == salesOrderId && item.ItemId == itemId);
        }

        public IEnumerable<SalesOrderLineItem> GetAllSalesOrderLineItems(int salesOrderId)
        {
            return _dbContext.SalesOrderLineItems
                .Where(item => item.SalesOrderId == salesOrderId)
                .ToList();
        }

        public void AddSalesOrderLineItem(SalesOrderLineItem lineItem)
        {
            _dbContext.SalesOrderLineItems.Add(lineItem);
            _dbContext.SaveChanges();
        }

        public void UpdateSalesOrderLineItem(SalesOrderLineItem lineItem)
        {
            _dbContext.Entry(lineItem).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteSalesOrderLineItem(int salesOrderId, int itemId)
        {
            var lineItem = _dbContext.SalesOrderLineItems
                .FirstOrDefault(item => item.SalesOrderId == salesOrderId && item.ItemId == itemId);

            if (lineItem != null)
            {
                _dbContext.SalesOrderLineItems.Remove(lineItem);
                _dbContext.SaveChanges();
            }
        }
    }
}
