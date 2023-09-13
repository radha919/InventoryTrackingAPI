using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface ISupplierRepo
    {
        public void AddSupplier(Supplier supplier);

        public void UpdateSupplier(Supplier supplier);

        public void DeleteSupplier(int id);

        public Supplier GetSupplier(int id);

        IEnumerable<Supplier> GetAllSupplier();
    }
}
