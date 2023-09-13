using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class SalesOrderService
    {
        ISalesOrderLineRepo _salesOrderRepository;
        public SalesOrderService(ISalesOrderLineRepo salesOrderRepository)
        {
            _salesOrderRepository = salesOrderRepository;
        }


        public void AddSalesOrder(SalesOrder salesOrder)
        {
            _salesOrderRepository.AddSalesOrder(salesOrder);
        }
        //update movie
        public void UpdateSalesOrder(SalesOrder salesOrder)
        {
            _salesOrderRepository.UpdateSalesOrder(salesorder);
        }
        //delete movie
        public void DeleteSalesOrder(int salesorderId)
        {
            _salesOrderRepository.DeleteSalesOrder(salesorderId);
        }
        //Get GetMovieByid
        public Order GetSalesOrderByid(int salesorderId)
        {
            return _salesOrderRepository.GetsalesOrderById(salesorderId);
        }
        //Get GetMovies
        public IEnumerable<SalesOrder> GetSalesOrders()
        {
            return _salesOrderRepository.GetSalesOrders();
        }
    }
}
