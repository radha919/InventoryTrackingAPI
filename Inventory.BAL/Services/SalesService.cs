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


        public void AddSales(SalesOrderr sales)
        {
            _salesRepository.AddSales(sales);
        }
        //update movie
        public void UpdateSales(SalesOrderr sales)
        {
            _salesRepository.UpdateSales(sales);
        }
        //delete movie
        public void DeleteSales(int saleId)
        {
            _salesRepository.DeleteSales(saleId);
        }
        //Get GetMovieByid
        public SalesOrderr GetSales(int saleId)
        {
            return _salesRepository.GetSales(saleId);
        }
        //Get GetMovies
        public IEnumerable<SalesOrderr> GetAllSales()
        {
            return _salesRepository.GetAllSales();
        }
    }
}
