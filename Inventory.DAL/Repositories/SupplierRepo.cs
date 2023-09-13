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
    public class SupplierRepo: ISupplierRepo
    {
        InventoryDbcontext _dbcontext;

        public SupplierRepo(InventoryDbcontext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddSupplier(Supplier supplier)
        {
            _dbcontext.Suppliers.Add(supplier);
            _dbcontext.SaveChanges();
        }

        public void DeleteSupplier(int supplierId)
        {
            var supplier = _dbcontext.Suppliers.Find(supplierId);
            _dbcontext.Suppliers.Remove(supplier);
            _dbcontext.SaveChanges();
        }

        public Supplier GetSupplier(int supplierId)
        {
            return _dbcontext.Suppliers.Find(supplierId);
        }

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _dbcontext.Suppliers.ToList();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _dbcontext.Entry(supplier).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
