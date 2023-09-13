using Inventory.DAL.Data;
using Inventory.EAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class CustomerService
    {
        private readonly InventoryDbcontext _context;

        public CustomerService(InventoryDbcontext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            // You can add any business logic or validation here
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int customerId)
        {
            // You can add any business logic or validation here
            return _context.Customers.Find(customerId);
        }

        public void AddCustomer(Customer customer)
        {
            // You can add any business logic or validation here
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            // You can add any business logic or validation here
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            // You can add any business logic or validation here
            var customerToDelete = _context.Customers.Find(customerId);
            if (customerToDelete != null)
            {
                _context.Customers.Remove(customerToDelete);
                _context.SaveChanges();
            }
        }
    }
}
