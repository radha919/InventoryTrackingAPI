using Inventory.DAL.Data;
using Inventory.EAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public class PurchaseLineRepo : IPurchaseLineRepo
    {
        InventoryDbcontext _dbcontext;

        public PurchaseLineRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddPurchaseLine(PurchaseLineItem purchaseLine)
        {
            _dbcontext.PurchasesLineItem.Add(purchaseLine);
            _dbcontext.SaveChanges();
        }

        public void DeletePurchaseLine(int purchaseLineId)
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
