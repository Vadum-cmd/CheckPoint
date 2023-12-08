using DAL;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace App.UnitTests
{
    [TestClass]
    public class UserQueriesTests
    {
        [TestMethod]
        public void GetInvoiceById_ValidId_ReturnsInvoice()
        {
            // Arrange
            int validId = 1;
            var invoices = new List<Invoice>
    {
        new Invoice { Id = validId, /* other properties */ }
    };

            var dbContextMock = new Mock<IAppDBContext>();
            dbContextMock.Setup(db => db.Invoice)
                .Returns((DbSet<Invoice>)invoices.AsQueryable());

            // Inject the mocked context into the static class
            UserQueries.SetDbContext((AppDBContext)dbContextMock.Object);

            // Act
            Invoice result = UserQueries.GetInvoiceById(validId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(validId, result.Id);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "Invoice is not found")]
        public void GetInvoiceById_InvalidId_ThrowsException()
        {
            // Arrange
            int invalidId = 999;
            var dbContextMock = new Mock<AppDBContext>();
            dbContextMock.Setup(db => db.Invoice)
                .Returns((Microsoft.EntityFrameworkCore.DbSet<Invoice>)new List<Invoice>().AsQueryable());

            // Inject the mocked context into the static class
            UserQueries.SetDbContext(dbContextMock.Object);

            // Act
            Invoice result = UserQueries.GetInvoiceById(invalidId);

            // Assert
            // Exception is expected
        }
    }
}