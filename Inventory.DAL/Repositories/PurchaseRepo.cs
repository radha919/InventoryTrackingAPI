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
    public class PurchaseRepo: IPurchaserepo
    {
        InventoryDbcontext _dbcontext;

        public PurchaseRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddPurchase(Purchase purchase)
        {
            _dbcontext.Purchases.Add(purchase);
            _dbcontext.SaveChanges();
        }

        public void DeletePurchase(int purchaseId)
        {
            var purchase = _dbcontext.Purchases.Find(purchaseId);
            _dbcontext.Purchases.Remove(purchase);
            _dbcontext.SaveChanges();
        }

        public Purchase GetPurchase(int purchaseId)
        {
            return _dbcontext.Purchases.Find(purchaseId);
        }

        public IEnumerable<Purchase> GetAllPurchase()
        {
            return _dbcontext.Purchases.ToList();
        }

        public void UpdatePurchase(Purchase purchase)
        {
            _dbcontext.Entry(purchase).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
