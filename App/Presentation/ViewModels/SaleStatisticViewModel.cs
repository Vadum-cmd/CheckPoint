namespace Presentation.ViewModels
{
    using System;

    public class SaleStatisticViewModel : ViewModelBase
    {
        public int Id { get; set; }

        public int SaleStatisticProductId { get; set; }

        public int SoldOut { get; set; }

        public DateTime SaleDate { get; set; }

        public int Expired { get; set; }
    }
}