using FontAwesome.Sharp;
using Presentation.ViewModels;
using System.Windows.Input;

namespace Presentation.ViewModels {
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private ViewModelBase _currentChildView;
        private string _caption;


        //Properties

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }

            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }

            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }


        //--> Commands
        public ICommand ShowProductsViewCommand { get; }
        public ICommand ShowInvoicesViewCommand { get; }
        public ICommand ShowSaleStatisticViewCommand { get; }
        public ICommand ShowReceiptsViewCommand { get; }
        public ICommand ShowActivityViewCommand { get; }

        public MainViewModel()
        {

            //Initialize commands
            ShowProductsViewCommand = new ViewModelCommand(ExecuteShowProductsViewCommand);
            ShowInvoicesViewCommand = new ViewModelCommand(ExecuteShowInvoicesViewCommand);
            ShowReceiptsViewCommand = new ViewModelCommand(ExecuteShowReceiptsViewCommand);
            ShowSaleStatisticViewCommand = new ViewModelCommand(ExecuteShowSaleStatisticViewCommand);
            ShowActivityViewCommand = new ViewModelCommand(ExecuteShowActivityViewCommand);


            //Default view
            ExecuteShowProductsViewCommand(null);

        }

        private void ExecuteShowProductsViewCommand(object obj)
        {
            CurrentChildView = new ProductsViewModel();
            Caption = "Products";
        }

        private void ExecuteShowInvoicesViewCommand(object obj)
        {
            CurrentChildView = new InvoicesViewModel();
            Caption = "Invoices";
        }

        private void ExecuteShowReceiptsViewCommand(object obj)
        {
            CurrentChildView = new ReceiptsViewModel();
            Caption = "Receipts";
        }

        private void ExecuteShowSaleStatisticViewCommand(object obj)
        {
            CurrentChildView = new SaleStatisticViewModel();
            Caption = "Sale statistic";
        }

        private void ExecuteShowActivityViewCommand(object obj)
        {
            CurrentChildView = new ActivityViewModel();
            Caption = "Activity";
        }

    }
}