namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }

        required public string Name { get; set; }

        required public float Price { get; set; }

        required public string Category { get; set; }

        required public string Description { get; set; }

        required public DateTime DateManufacture { get; set; }

        required public DateTime DateExpiration { get; set; }

        required public int InStock { get; set; }

        public IList<SaleStatistic>? SaleStatistics { get; set; }

        public IList<Action>? Actions { get; set; }

        required public IList<ProductInvoice> ProductInvoices { get; set; }

        public IList<ProductReceipt>? ProductReceipts { get; set; }
    }
}