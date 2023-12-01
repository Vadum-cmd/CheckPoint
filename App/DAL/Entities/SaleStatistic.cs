namespace DAL.Entities
{
    using System;

    public class SaleStatistic
    {
        public int Id { get; set; }

        required public int SaleStatisticProductId { get; set; }

        public int? SoldOut { get; set; }

        public DateTime? SaleDate { get; set; }

        public int? Expired { get; set; }

        required public Product Product { get; set; }
    }
}