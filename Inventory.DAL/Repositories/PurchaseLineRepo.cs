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
    public class PurchaseLineRepo : IPurchaseLineRepo
    {
        InventoryDbcontext _dbcontext;

        public PurchaseLineRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddPurchaseLine(PurchaseLineItem purchaseLine)
        {
            _dbcontext.PurchasesLineItem.Add(purchaseLine);
            _dbcontext.SaveChanges();
        }

        public void DeletePurchaseLine(int purchaseLineId)
        {
            var purchaseLine = _dbcontext.PurchasesLineItem.Find(purchaseLineId);
            _dbcontext.PurchasesLineItem.Remove(purchaseLine);
            _dbcontext.SaveChanges();
        }

        public PurchaseLineItem GetPurchaseLine(int purchaseLineId)
        {
            return _dbcontext.PurchasesLineItem.Find(purchaseLineId);
        }

        public IEnumerable<PurchaseLineItem> GetAllPurchaseLine()
        {
            return _dbcontext.PurchasesLineItem.ToList();
        }

        public void UpdatePurchaseLine(PurchaseLineItem purchaseLine)
        {
            _dbcontext.Entry(purchaseLine).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}

