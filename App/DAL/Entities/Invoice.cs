using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Invoice
    {
        public required int Id { get; set; }
        public required DateTime DateOf { get; set; }
        public required string Provider { get; set; }
        public required int TotalPrice { get; set; }

        public required IList<ProductInvoice> ProductInvoices { get; set; }
    }
}
