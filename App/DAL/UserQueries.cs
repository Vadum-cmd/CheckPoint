using DAL.Data;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UserQueries
    {
        private static readonly AppDBContext _dbContext;

        static UserQueries() 
        {
            _dbContext = new AppDBContext();
        }

        public static Invoice GetInvoiceById(int id) 
        {
            List<Invoice> invoices = (from invoice in _dbContext.Invoice
                                      where invoice.Id == id
                                      select invoice).ToList();
            if (invoices.Count == 1) 
            {
                return invoices[0];
            }

            throw new Exception("Invoice is not found");
        }
        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = (from invoice in _dbContext.Invoice
                                      select invoice).ToList();
            if (invoices.Count >= 0)
            {
                return invoices;
            }

            throw new Exception("There are no invoices");
        }
    }
}
