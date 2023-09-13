using Inventory.DAL.Data;
using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class OrderService
    {
        IOrderRepo _orderRepository;
        public OrderService(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

       
        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }
        //update movie
        public void UpdateOrder(Order order)
        {
            _orderRepository.UpdateOrder(order);
        }
        //delete movie
        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }
        //Get GetMovieByid
        public Order GetOrder(int orderId)
        {
            return _orderRepository.GetOrder(orderId);
        }
        //Get GetMovies
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }
    }


}

