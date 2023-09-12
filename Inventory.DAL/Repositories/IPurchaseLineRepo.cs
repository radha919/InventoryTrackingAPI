using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface IPurchaseLineRepo
    {
        public void AddPurchaseLineRepo(PurchaseLineRepo purchaseOrderLineItem);

        public void UpdatePurchaseLineRepo(PurchaseLineRepo purchaseOrderLineItem);

        public void DeletePurchaseOrderLineItem(int id);

        public PurchaseLineRepo? GetPurchaseOrderLineItem(int id);

        public List<PurchaseLineRepo> GetAllPurchaseOrderLineItems();
    }
}
