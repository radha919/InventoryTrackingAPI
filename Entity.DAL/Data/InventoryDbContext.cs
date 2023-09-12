using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DAL.Data
{
    public class InventoryDbContext(DbContextOptions<InventoryDbContext> options) :base(Options)
    {

    }
}
