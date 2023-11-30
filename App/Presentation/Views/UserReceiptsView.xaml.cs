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
    /// Interaction logic for UserReceipts.xaml
    /// </summary>
    public partial class UserReceipts : UserControl
    {
        public List<ProductReceipt> Data { get; set; }
        public List<ReceiptsViewModel> ReceiptsViewModels { get; set; }
        public UserReceipts()
        {
            InitializeComponent();
            DataContext = this;

            Data = UserQueries.GetReceipts();
            ReceiptsViewModels = new List<ReceiptsViewModel>();

            foreach (var receipt in Data)
            {
                ReceiptsViewModels.Add(new ReceiptsViewModel
                {
                    Id = receipt.ReceiptId,
                    ProductId = receipt.ProductId,
                    Amount = receipt.Amount,
                    Price = receipt.Price,
                    ActionId = receipt.ActionId == null ? -1 : (int)receipt.ActionId
                });
            }
        }
    }
}
