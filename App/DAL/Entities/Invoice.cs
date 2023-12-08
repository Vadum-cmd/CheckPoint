namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Invoice
    {
        public int Id { get; set; }

        public DateTime DateOf { get; set; }

        public string Provider { get; set; }

        public int TotalPrice { get; set; }

        public IList<ProductInvoice> ProductInvoices { get; set; }
    }
}