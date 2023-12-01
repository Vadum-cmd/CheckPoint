namespace Presentation.ViewModels
{
    using System.Windows.Input;

    public class MainViewModel : ViewModelBase
    {
        // Fields
        private ViewModelBase _currentChildView;
        private string _caption;


        // Properties

        public ViewModelBase CurrentChildView
        {
            get
            {
                return this._currentChildView;
            }

            set
            {
                this._currentChildView = value;
                this.OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return this._caption;
            }

            set
            {
                this._caption = value;
                this.OnPropertyChanged(nameof(Caption));
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

            // Initialize commands
            this.ShowProductsViewCommand = new ViewModelCommand(this.ExecuteShowProductsViewCommand);
            this.ShowInvoicesViewCommand = new ViewModelCommand(this.ExecuteShowInvoicesViewCommand);
            this.ShowReceiptsViewCommand = new ViewModelCommand(this.ExecuteShowReceiptsViewCommand);
            this.ShowSaleStatisticViewCommand = new ViewModelCommand(this.ExecuteShowSaleStatisticViewCommand);
            this.ShowActivityViewCommand = new ViewModelCommand(this.ExecuteShowActivityViewCommand);

            // Default view
            this.ExecuteShowProductsViewCommand(null);
        }

        private void ExecuteShowProductsViewCommand(object? obj)
        {
            this.CurrentChildView = new ProductsViewModel();
            this.Caption = "Products";
        }

        private void ExecuteShowInvoicesViewCommand(object obj)
        {
            this.CurrentChildView = new InvoicesViewModel();
            this.Caption = "Invoices";
        }

        private void ExecuteShowReceiptsViewCommand(object obj)
        {
            this.CurrentChildView = new ReceiptsViewModel();
            this.Caption = "Receipts";
        }

        private void ExecuteShowSaleStatisticViewCommand(object obj)
        {
            this.CurrentChildView = new SaleStatisticViewModel();
            this.Caption = "Sale statistic";
        }

        private void ExecuteShowActivityViewCommand(object obj)
        {
            this.CurrentChildView = new ActivityViewModel();
            this.Caption = "Activity";
        }

    }
}