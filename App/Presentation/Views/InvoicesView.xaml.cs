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
        public List<Invoice> temp { get; set; } 
        public InvoicesView()
        {
            InitializeComponent();
            DataContext = this;
            List<InvoicesViewModel> invoicesViewModels;
            temp = UserQueries.GetInvoices();
        }
    }
}
