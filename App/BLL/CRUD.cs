using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Entities;

namespace BLL
{
    public class CRUD
    {
        public static void InsertAction(int id, int actionProductId, float discount, 
            DateTime dateFrom, DateTime dateTo, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var myAction = new DAL.Entities.Action
                {
                    Id = id,
                    ActionProductId = actionProductId,
                    Discount = discount,
                    DateFrom = dateFrom,
                    DateTo = dateTo,
                    Product = product
                };
                context.Action.Add(myAction);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertAction(int id, int actionProductId, float discount, 
            DateTime dateFrom, DateTime dateTo, int amount, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var myAction = new DAL.Entities.Action
                {
                    Id = id,
                    ActionProductId = actionProductId,
                    Discount = discount,
                    DateFrom = dateFrom,
                    DateTo = dateTo,
                    Amount = amount,
                    Product = product
                };
                context.Action.Add(myAction);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertEmployee(int id, string name, string surname, string position, string login, string password, 
            int employeePermissionId, EmployeePermission employeePermission, IList<EmployeeSession> employeeSessions)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var employee = new Employee
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    Position = position,
                    Login = login,
                    Password = password,
                    EmployeePermissionId = employeePermissionId,
                    EmployeePermission = employeePermission,
                    EmployeeSessions = employeeSessions
                };
                context.Employee.Add(employee);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertEmployeePermission(int id, string title, string acts, IList<Employee> employees)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var employeePermission = new EmployeePermission
                {
                    Id = id,
                    Title = title,
                    Acts = acts,
                    Employees = employees
                };
                context.EmployeePermission.Add(employeePermission);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertEmployeeSession(int id, int employeeId, DateTime time, Employee employee)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var employeeSession = new EmployeeSession
                {
                    Id = id,
                    EmployeeId = employeeId,
                    Time = time,
                    Employee = employee
                };
                context.EmployeeSession.Add(employeeSession);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertInvoice(int id, DateTime dateOf, string provider, 
            int totalPrice, IList<ProductInvoice> productInvoices)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var invoice = new Invoice
                {
                    Id = id,
                    DateOf = dateOf,
                    Provider = provider,
                    TotalPrice = totalPrice,
                    ProductInvoices = productInvoices
                };
                context.Invoice.Add(invoice);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertProduct(int id, string name, float price, string category, string description, 
            DateTime dateManufacture, DateTime dateExpiration, int inStock, IList<SaleStatistic> saleStatistics, 
            IList<DAL.Entities.Action> actions, IList<ProductInvoice> productInvoices, IList<ProductReceipt> productReceipts)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var product = new Product
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Category = category,
                    Description = description,
                    DateManufacture = dateManufacture,
                    DateExpiration = dateExpiration,
                    InStock = inStock,
                    SaleStatistics = saleStatistics,
                    Actions = actions,
                    ProductInvoices = productInvoices,
                    ProductReceipts = productReceipts
                };
                context.Product.Add(product);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertProductInvoice(int invoiceId, int productId, int amount, Invoice invoice, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var productInvoice = new ProductInvoice
                {
                    InvoiceId = invoiceId,
                    ProductId = productId,
                    Amount = amount,
                    Invoice = invoice,
                    Product = product
                };
                context.ProductInvoice.Add(productInvoice);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertProductReceipt(int receiptId, int productId, int amount, float price, 
            int actionId, Receipt receipt, Product product, DAL.Entities.Action action)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var productReceipt = new ProductReceipt
                {
                    ReceiptId = receiptId,
                    ProductId = productId,
                    Amount = amount,
                    Price = price,
                    ActionId = actionId,
                    Receipt = receipt,
                    Product = product,
                    Action = action
                };
                context.ProductReceipt.Add(productReceipt);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertProductReceipt(int receiptId, int productId, int amount, float price,
            Receipt receipt, Product product, DAL.Entities.Action action)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var productReceipt = new ProductReceipt
                {
                    ReceiptId = receiptId,
                    ProductId = productId,
                    Amount = amount,
                    Price = price,
                    Receipt = receipt,
                    Product = product,
                    Action = action
                };
                context.ProductReceipt.Add(productReceipt);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertReceipt(int id, float totalPrice, DateTime dateOf, IList<ProductReceipt> productReceipts)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var receipt = new Receipt
                {
                    Id = id,
                    TotalPrice = totalPrice,
                    DateOf = dateOf,
                    ProductReceipts = productReceipts
                };
                context.Receipt.Add(receipt);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void InsertSaleStatistic(int id, int saleStatisticProductId, int soldOut, DateTime saleDate, int expired, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SoldOut = soldOut,
                    SaleDate = saleDate,
                    Expired = expired,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, DateTime saleDate, int expired, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SaleDate = saleDate,
                    Expired = expired,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, int soldOut, int expired, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SoldOut = soldOut,
                    Expired = expired,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, int soldOut, DateTime saleDate, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SoldOut = soldOut,
                    SaleDate = saleDate,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, int expired, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    Expired = expired,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, Product product, int soldOut)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SoldOut = soldOut,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, DateTime saleDate, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    SaleDate = saleDate,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }
        public static void InsertSaleStatistic(int id, int saleStatisticProductId, Product product)
        {
            using (var context = new AppDBContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                var saleStatistic = new SaleStatistic
                {
                    Id = id,
                    SaleStatisticProductId = saleStatisticProductId,
                    Product = product
                };
                context.SaleStatistic.Add(saleStatistic);

                // Saves changes
                context.SaveChanges();
            }
        }



    }
}
