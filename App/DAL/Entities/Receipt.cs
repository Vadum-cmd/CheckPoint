namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;

    public class Receipt
    {
        public int Id { get; set; }

        required public float TotalPrice { get; set; }

        required public DateTime DateOf { get; set; }

        required public IList<ProductReceipt> ProductReceipts { get; set; }
    }
}