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
        InventoryDbcontext _dbcontext;

        public SalesOrderLineRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddSalesOrder(SalesOrderLineItem salesOrder)
        {
            _dbcontext.SalesOrdersLineItem.Add(salesOrder);
            _dbcontext.SaveChanges();
        }

        public void DeleteSalesOrder(int salesOrderId)
        {
            var salesOrder = _dbcontext.SalesOrdersLineItem.Find(salesOrderId);
            _dbcontext.SalesOrdersLineItem.Remove(salesOrder);
            _dbcontext.SaveChanges();
        }

        public SalesOrderLineItem GetSalesOrder(int salesOrderId)
        {
            return _dbcontext.SalesOrdersLineItem.Find(salesOrderId);
        }

        public IEnumerable<SalesOrderLineItem> GetAllSalesOrder()
        {
            return _dbcontext.SalesOrdersLineItem.ToList();
        }

        public void UpdateSalesOrder(SalesOrderLineItem salesOrder)
        {
            _dbcontext.Entry(salesOrder).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
    }
