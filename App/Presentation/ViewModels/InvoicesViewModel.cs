using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using DAL.Data;
using Microsoft.EntityFrameworkCore.Diagnostics;
using DAL.Entities;


namespace Presentation.ViewModels
{
    public class InvoiceViewModel : ViewModelBase
    {
        private int _id;
        private DateTime _dateOf;
        private string _provider;
        private int _totalPrice;

        public int Id
        { 
            get { return _id; } 
            set 
            {
                if (_id != value)
                { 
                    _id = value; 
                    OnPropertyChanged(nameof(Id));
                }
            }
        }
        public DateTime DateOf
        {
            get { return _dateOf; }
            set
            {
                if (_dateOf != value)
                {
                    _dateOf = value;
                    OnPropertyChanged(nameof(DateOf));
                }
            }
        }
        public string Provider
        {
            get { return _provider; }
            set
            {
                if (_provider != value)
                {
                    _provider = value;
                    OnPropertyChanged(nameof(Provider));
                }
            }
        }
        public int TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                if (_totalPrice != value)
                {
                    _totalPrice = value;
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }
        }

        public InvoiceViewModel(int id, DateTime dateOf, string provider, int totalPrice)
        {
            _id = id;
            _dateOf = dateOf;
            _provider = provider;
            _totalPrice = totalPrice;
        }
    }

    public class InvoicesViewModel : ViewModelBase
    {
        private ObservableCollection<InvoiceViewModel> _invoices;
        public ObservableCollection<InvoiceViewModel> Invoices 
        { 
            get { return _invoices; } 
            set 
            { 
                _invoices = value;
                OnPropertyChanged(nameof(Invoices));
            }
        }

        public InvoicesViewModel()
        {
            _invoices = new ObservableCollection<InvoiceViewModel>();

            using (var context = new AppDBContext())
            {
                ObservableCollection<Invoice> InvoicesDb = new ObservableCollection<Invoice>(context.Invoice.ToList());

                foreach(var invoice in InvoicesDb)
                {
                    Invoices.Add(new InvoiceViewModel(invoice.Id, invoice.DateOf, invoice.Provider, invoice.TotalPrice));
                }
            }
        }
    }
}