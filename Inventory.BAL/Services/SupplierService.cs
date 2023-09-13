using Inventory.DAL.Repositories;
using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.BAL.Services
{
    public class SupplierService
    {
        ISupplierRepo _supplierRepository;
        public SupplierService(ISupplierRepo supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }


        public void AddSupplier(Supplier supplier)
        {
            _supplierRepository.AddSupplier(supplier);
        }
        //update movie
        public void UpdateSupplier(Supplier supplier)
        {
            _supplierRepository.UpdateSupplier(supplier);
        }
        //delete movie
        public void DeleteSupplier(int supplierId)
        {
            _supplierRepository.DeleteSupplier(supplierId);
        }
        //Get GetMovieByid
        public Supplier GetSupplier(int supplierId)
        {
            return _supplierRepository.GetSupplier(supplierId);
        }
        //Get GetMovies
        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _supplierRepository.GetAllSupplier();
        }
    }
}
