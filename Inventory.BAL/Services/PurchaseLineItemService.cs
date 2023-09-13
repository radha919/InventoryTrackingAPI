using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    internal class PurchaseLineItemService
    {
        IPurchaseLineRepo _purchaseLineRepository;
        public PurchaseLineItemService(IPurchaseLineRepo purchaseLineRepository)
        {
            _purchaseLineRepository = purchaseLineRepository;
        }


        public void AddPurchaseLine(PurchaseLineItem purchaseLine)
        {
            _purchaseLineRepository.AddPurchaseLine(purchaseLine);
        }
        //update movie
        public void UpdatePurchaseLine(PurchaseLineItem purchaseLine)
        {
            _purchaseLineRepository.UpdatePurchaseLine(purchaseLine);
        }
        //delete movie
        public void DeletePurchaseLine(int purchaseLineId)
        {
            _purchaseLineRepository.DeletePurchaseLine(purchaseLineId);
        }
        //Get GetMovieByid
        public Order GetPurchaseLineByid(int purchaseLineId)
        {
            return _purchaseLineRepository.GetPurchaseLineById(purchaseLineId);
        }
        //Get GetMovies
        public IEnumerable<PurchaseLineItem> GetPurchaseLine()
        {
            return _purchaseLineRepository.GetPurchaseLine();
        }
    }
}
