using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
  
         
        public interface ICustomerRepo
        {
            public void AddCustomer(Customer customer);

            public void UpdateCustomer(Customer customer);

            public void DeleteCustomer(int id);

            public Customer GetCustomer(int id);

            public List<Customer> GetAllCustomers();
        }
    }


