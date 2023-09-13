using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface IPurchaserepo
    {
        public void AddPurchase(Purchase purchase);

        public void UpdatePurchase(Purchase purchase);

        public void DeletePurchase(int id);

        public Purchase GetPurchase(int id);

        IEnumerable<Purchase> GetAllPurchase();
    }
}
