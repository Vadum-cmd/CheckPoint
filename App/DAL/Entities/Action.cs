namespace DAL.Entities
{
    using System;

    public class Action
    {
        public int Id { get; set; }

        required public int ActionProductId { get; set; }

        required public float Discount { get; set; }

        required public DateTime DateFrom { get; set; }

        required public DateTime DateTo { get; set; }

        public int? Amount { get; set; }

        required public Product Product { get; set; }
    }
}