namespace Presentation.ViewModels
{
    using System;

    public class ProductsViewModel : ViewModelBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public DateTime DateManufacture { get; set; }

        public DateTime DateExpiration { get; set; }

        public int InStock { get; set; }
    }
}