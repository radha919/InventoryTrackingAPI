using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
    }
}
