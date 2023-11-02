using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductInvoice
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public required Invoice Invoice { get; set; }
        public required Product Product { get; set; }
    }
}
