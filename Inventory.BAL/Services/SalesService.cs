using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class SalesService
    {
        ISalesOrderRepo _salesRepository;
        public SalesService(ISalesOrderRepo salesRepository)
        {
            _salesRepository = salesRepository;
        }


        public void AddSales(Sales sale)
        {
            _salesRepository.AddSales(sale);
        }
        //update movie
        public void UpdateSales(Sales sale)
        {
            _salesRepository.UpdateSales(sale);
        }
        //delete movie
        public void DeleteSales(int saleId)
        {
            _salesRepository.DeleteSales(saleId);
        }
        //Get GetMovieByid
        public Order GetSalesByid(int saleId)
        {
            return _salesRepository.GetSalesById(saleId);
        }
        //Get GetMovies
        public IEnumerable<Sale> GetSales()
        {
            return _salesRepository.GetSales();
        }
    }
}
