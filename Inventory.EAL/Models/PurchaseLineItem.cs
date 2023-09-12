using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.EAL.Models
{
    public class PurchaseLineItem
    {
        [Key]
        public int PurchaseLineItemId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

    }
}
