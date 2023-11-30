using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductReceipt
    {
        public required int ReceiptId { get; set; }
        public required int ProductId { get; set; }
        public required int Amount { get; set; }
        public required float Price { get; set; }
        public int? ActionId { get; set; }

        public required Receipt Receipt { get; set; }
        public required Product Product { get; set; }
        public Action? Action { get; set; }
    }
}