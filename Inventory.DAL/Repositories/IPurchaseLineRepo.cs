using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface IPurchaseLineRepo
    {
        public void AddPurchaseLine(PurchaseLineItem purchaseLine);

        public void UpdatePurchaseLine(PurchaseLineItem purchaseLine);

        public void DeletePurchase(int id);

        public PurchaseLineItem GetPurchaseLine(int id);

        IEnumerable<PurchaseLineItem> GetAllPurchaseLine();
    }
}
