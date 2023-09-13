using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class PurchaseService
    {
        IPurchaserepo _purchaseRepository;
        public PurchaseService(IPurchaserepo purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }


        public void AddPurchase(Purchase purchase)
        {
            _purchaseRepository.AddPurchase(purchase);
        }
        //update movie
        public void UpdatePurchase(Purchase purchase)
        {
            _purchaseRepository.UpdatePurchase(purchase);
        }
        //delete movie
        public void DeletePurchase(int purchaseId)
        {
            _purchaseRepository.DeletePurchase(purchaseId);
        }
        //Get GetMovieByid
        public Purchase GetPurchase(int purchaseId)
        {
            return _purchaseRepository.GetPurchase(purchaseId);
        }
        //Get GetMovies
        public IEnumerable<Purchase> GetAllPurchase()
        {
            return _purchaseRepository.GetAllPurchase();
        }
    }
}
