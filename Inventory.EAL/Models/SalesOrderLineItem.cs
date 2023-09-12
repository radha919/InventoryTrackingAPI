using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.EAL.Models
{
    public class SalesOrderLineItem
    {
        [Key]
        public int SalesOrderLineItemId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        [ForeignKey("SalesOrder")]
        public int SaleOrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

    }
}
