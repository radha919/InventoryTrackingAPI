using Inventory.DAL.Data;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public class CustomerRepository : ICustomerRepo
    {
        InventoryDbcontext _dbcontext;

        public CustomerRepository(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddCustomer(Customer customer)
        {
            _dbcontext.Customers.Add(customer);
            _dbcontext.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _dbcontext.Customers.Find(customerId);
            _dbcontext.Customers.Remove(customer);
            _dbcontext.SaveChanges();
        }

        public Customer GetCustomer(int customerId)
        {
            return _dbcontext.Customers.Find(customerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbcontext.Customers.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            _dbcontext.Entry(customer).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
    
