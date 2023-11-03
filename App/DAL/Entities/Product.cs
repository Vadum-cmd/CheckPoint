using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required float Price { get; set; }
        public required string Category { get; set; }
        public required string Description { get; set; }
        public required DateTime DateManufacture { get; set; }
        public required DateTime DateExpiration { get; set; }
        public required int InStock { get; set; }

        public IList<SaleStatistic>? SaleStatistics { get; set; }
        public IList<Action>? Actions { get; set; }
        public required IList<ProductInvoice> ProductInvoices { get; set; }
        public IList<ProductReceipt>? ProductReceipts { get; set; }
    }
}
