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
        private readonly InventoryDbcontext _dbcontext;
        public CustomerRepository(InventoryDbcontext dbcontext)
        {
           _dbcontext = dbcontext;
        }
        public void AddCustomer(Customer customer)
        {
            _dbcontext.Customer.Add(customer);
            _dbcontext.Customer.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
