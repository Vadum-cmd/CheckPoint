namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DAL.Data;
    using DAL.Entities;

    public static class UserQueries
    {
        private static AppDBContext dbContext;

        static UserQueries() 
        {
            dbContext = new AppDBContext();
        }

        public static void SetDbContext(AppDBContext mockDbContext)
        {
            dbContext = mockDbContext;
        }

        public static Invoice GetInvoiceById(int id)
        {
            List<Invoice> invoices = (from invoice in dbContext.Invoice
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
            List<Invoice> invoices = (from invoice in dbContext.Invoice
                                      select invoice).ToList();
            if (invoices.Count >= 0)
            {
                return invoices;
            }

            throw new Exception("There are no invoices");
        }

        public static Entities.Action GetActionById(int id)
        {
            List<Entities.Action> actions = (from action in dbContext.Action
                                      where action.Id == id
                                      select action).ToList();
            if (actions.Count == 1)
            {
                return actions[0];
            }

            throw new Exception("Action is not found");
        }

        public static List<Entities.Action> GetActions()
        {
            List<Entities.Action> actions = (from action in dbContext.Action
                                      select action).ToList();
            if (actions.Count >= 0)
            {
                return actions;
            }

            throw new Exception("There are no actions");
        }

        public static EmployeeSession GetSessionById(int id)
        {
            List<EmployeeSession> sessions = (from session in dbContext.EmployeeSession
                                              where session.Id == id
                                              select session).ToList();
            if (sessions.Count == 1)
            {
                return sessions[0];
            }

            throw new Exception("Session is not found");
        }

        public static List<EmployeeSession> GetSessions()
        {
            List<EmployeeSession> sessions = (from session in dbContext.EmployeeSession
                                      select session).ToList();
            if (sessions.Count >= 0)
            {
                return sessions;
            }

            throw new Exception("There are no sessions");
        }

        public static SaleStatistic GetStatisticById(int id)
        {
            List<SaleStatistic> statistics = (from statistic in dbContext.SaleStatistic
                                            where statistic.Id == id
                                            select statistic).ToList();
            if (statistics.Count == 1)
            {
                return statistics[0];
            }

            throw new Exception("Statistic is not found");
        }

        public static List<SaleStatistic> GetStatistics()
        {
            List<SaleStatistic> statistics = (from statistic in dbContext.SaleStatistic
                                            select statistic).ToList();
            if (statistics.Count >= 0)
            {
                return statistics;
            }

            throw new Exception("There are no statistics");
        }

        public static ProductReceipt GetReceiptById(int id)
        {
            List<ProductReceipt> receipts = (from receipt in dbContext.ProductReceipt
                                               where receipt.ReceiptId == id
                                               select receipt).ToList();
            if (receipts.Count == 1)
            {
                return receipts[0];
            }

            throw new Exception("Receipt is not found");
        }

        public static List<ProductReceipt> GetReceipts()
        {
            List<ProductReceipt> receipts = (from receipt in dbContext.ProductReceipt
                                               select receipt).ToList();
            if (receipts.Count >= 0)
            {
                return receipts;
            }

            throw new Exception("There are no receipts");
        }

        public static Product GetProductById(int id)
        {
            List<Product> products = (from product in dbContext.Product
                                             where product.Id == id
                                             select product).ToList();
            if (products.Count == 1)
            {
                return products[0];
            }

            throw new Exception("Product is not found");
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = (from product in dbContext.Product
                                      select product).ToList();
            if (products.Count >= 0)
            {
                return products;
            }

            throw new Exception("There are no products");
        }
    }
}
