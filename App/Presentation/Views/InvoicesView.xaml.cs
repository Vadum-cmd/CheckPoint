using DAL;
using DAL.Entities;
using Microsoft.Identity.Client;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for InvoicesView.xaml
    /// </summary>
    public partial class InvoicesView : UserControl
    {
        public List<Invoice> Data { get; set; }
        public List<InvoicesViewModel> InvoicesViewModels { get; set; } 
        public InvoicesView()
        {
            InitializeComponent();
            DataContext = this;

            Data = UserQueries.GetInvoices();
            InvoicesViewModels = new List<InvoicesViewModel>();

            foreach (var invoice in Data) 
            {
                InvoicesViewModels.Add(new InvoicesViewModel
                {
                    Id = invoice.Id,
                    DateOf = invoice.DateOf,
                    Provider = invoice.Provider,
                    TotalPrice = invoice.TotalPrice,
                });
            }
        }
    }
}
