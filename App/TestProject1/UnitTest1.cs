using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Data;
using Presentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UserQueriesTests
{
    private static DbContextOptions<AppDBContext> dbContextOptions;

    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        dbContextOptions = new DbContextOptionsBuilder<AppDBContext>()
            .UseInMemoryDatabase(databaseName: "InMemory_UserQueries_Database")
            .Options;

        using (var dbContext = new AppDBContext(dbContextOptions))
        {
            dbContext.Invoice.AddRange(new List<Invoice>
            {
                new Invoice { Id = 1, Amount = 100.50, CustomerName = "Customer1" },
                new Invoice { Id = 2, Amount = 75.20, CustomerName = "Customer2" }
            });

            dbContext.Action.AddRange(new List<Entities.Action>
            {
                new Entities.Action { Id = 1, Description = "Action1" },
                new Entities.Action { Id = 2, Description = "Action2" }
            });

            dbContext.EmployeeSession.AddRange(new List<EmployeeSession>
            {
                new EmployeeSession { Id = 1, StartTime = DateTime.Now.AddHours(-1) },
                new EmployeeSession { Id = 2, StartTime = DateTime.Now.AddHours(-2) }
            });

            dbContext.SaleStatistic.AddRange(new List<SaleStatistic>
            {
                new SaleStatistic { Id = 1, SalesAmount = 500.75, ProductName = "Product1" },
                new SaleStatistic { Id = 2, SalesAmount = 300.20, ProductName = "Product2" }
            });

            dbContext.ProductReceipt.AddRange(new List<ProductReceipt>
            {
                new ProductReceipt { ReceiptId = 1, ProductName = "Product1", Quantity = 5 },
                new ProductReceipt { ReceiptId = 2, ProductName = "Product2", Quantity = 3 }
            });

            dbContext.Product.AddRange(new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 50.00 },
                new Product { Id = 2, Name = "Product2", Price = 30.00 }
            });

            dbContext.SaveChanges();
        }
    }
}