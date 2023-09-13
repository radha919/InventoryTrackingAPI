using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class SalesOrderService:ISalesOrderLineRepo
    {
        ISalesOrderLineRepo _salesOrderRepository;
        public SalesOrderService(ISalesOrderLineRepo salesOrderRepository)
        {
            _salesOrderRepository = salesOrderRepository;
        }


        public void AddSalesOrder(SalesOrderLineItem salesOrder)
        {
            _salesOrderRepository.AddSalesOrder(salesOrder);
        }
        //update movie
        public void UpdateSalesOrder(SalesOrderLineItem salesOrder)
        {
            _salesOrderRepository.UpdateSalesOrder(salesOrder);
        }
        //delete movie
        public void DeleteSalesOrder(int salesorderId)
        {
            _salesOrderRepository.DeleteSalesOrder(salesorderId);
        }
        //Get GetMovieByid
        public SalesOrderLineItem GetSalesOrder(int salesorderId)
        {
            return _salesOrderRepository.GetSalesOrder(salesorderId);
        }
        //Get GetMovies
        public IEnumerable<SalesOrderLineItem> GetAllSalesOrder()
        {
            return _salesOrderRepository.GetAllSalesOrder();
        }
    }
}
