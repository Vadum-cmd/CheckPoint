namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Invoice
    {
        public int Id { get; set; }

        required public DateTime DateOf { get; set; }

        required public string Provider { get; set; }

        required public int TotalPrice { get; set; }

        required public IList<ProductInvoice> ProductInvoices { get; set; }
    }
}