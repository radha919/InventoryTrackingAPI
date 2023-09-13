using Inventory.EAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface ISalesOrderRepo
    {
        public void AddSales(SalesOrderr sales);

        public void UpdateSales(SalesOrderr sales);

        public void DeleteSales(int id);

        public SalesOrderr GetSales(int id);

        IEnumerable<SalesOrderr> GetAllSales();
    }
}
