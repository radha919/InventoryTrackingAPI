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

    public class SalesOrder : ISalesOrderRepo
    {
        InventoryDbcontext _dbcontext;

        public SalesOrder(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddSales(SalesOrder salesOrder)
        {
            _dbcontext.SalesOrders.Add(salesOrder);
            _dbcontext.SaveChanges();
        }

        public void DeleteSales(int salesId)
        {
            var sale = _dbcontext.SalesOrders.Find(salesId);
            _dbcontext.SalesOrders.Remove(salesId);
            _dbcontext.SaveChanges();
        }

        public SalesOrder GetSales(int salesOrderId)
        {
            return _dbcontext.SalesOrders.Find(salesOrderId);
        }

        public IEnumerable<SalesOrder> GetAllSales()
        {
            return _dbcontext.SalesOrders.ToList();
        }

        public void UpdateSales(SalesOrder salesOrder)
        {
            _dbcontext.Entry(salesOrder).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
