using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class OrderLineItemService
    {
        IOrderLineRepository _orderLineRepository;
        public OrderLineItemService(IOrderLineRepository orderRepository)
        {
            _orderLineRepository = orderRepository;
        }


        public void AddOrderLine(OrderLineItem orderLine)
        {
            _orderLineRepository.AddOrderLine(orderLine);
        }
        //update movie
        public void UpdateOrderLine(OrderLineItem orderLine)
        {
            _orderLineRepository.UpdateOrderLine(orderLine);
        }
        //delete movie
        public void DeleteOrderLine(int orderId)
        {
            _orderLineRepository.DeleteOrderLine(orderId);
        }
        //Get GetMovieByid
        public OrderLineItem GetOrderLine(int orderId)
        {
            return _orderLineRepository.GetOrderLine(orderId);
        }
        //Get GetMovies
        public IEnumerable<OrderLineItem> GetAllOrdersLine()
        {
            return _orderLineRepository.GetAllOrdersLine();
        }
    }
}
