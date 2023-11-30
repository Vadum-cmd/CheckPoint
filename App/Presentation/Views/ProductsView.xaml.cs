using DAL.Entities;
using DAL;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation.Views
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public List<Product> Data { get; set; }
        public List<ProductsViewModel> ProductsViewModels { get; set; }
        public ProductView()
        {
            InitializeComponent();
            DataContext = this;

            Data = UserQueries.GetProducts();
            ProductsViewModels = new List<ProductsViewModel>();

            foreach (var product in Data)
            {
                ProductsViewModels.Add(new ProductsViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Category = product.Category,
                    Description = product.Description,
                    DateManufacture = product.DateManufacture,
                    DateExpiration = product.DateExpiration,
                    InStock = product.InStock
                });
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
