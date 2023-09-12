using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public interface ISupplier
    {
        int SupplierId { get; }
        string Name { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
    }
}
