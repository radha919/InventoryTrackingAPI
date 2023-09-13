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
        public void AddSales(SalesOrder sales);

        public void UpdateSales(SalesOrder sales);

        public void DeleteSales(int id);

        public SalesOrder GetSales(int id);

        IEnumerable<SalesOrder> GetAllSales();
    }
}
