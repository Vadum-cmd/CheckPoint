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
        public required int InvoiceId { get; set; }
        public required int ProductId { get; set; }
        public required int Amount { get; set; }

        public required Invoice Invoice { get; set; }
        public required Product Product { get; set; }
    }
}