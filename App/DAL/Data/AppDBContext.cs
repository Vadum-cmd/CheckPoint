namespace DAL.Data
{
    using System;
    using System.Configuration;
    using DAL.Entities;
    using Microsoft.EntityFrameworkCore;
    using Action = DAL.Entities.Action;

    public class AppDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeePermission> EmployeePermission { get; set; }

        public DbSet<EmployeeSession> EmployeeSession { get; set; }

        public DbSet<Receipt> Receipt { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Entities.Action> Action { get; set; }

        public DbSet<ProductInvoice> ProductInvoice { get; set; }

        public DbSet<ProductReceipt> ProductReceipt { get; set; }

        public DbSet<SaleStatistic> SaleStatistic { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = ConfigurationManager.ConnectionStrings["RostikConnection"].ConnectionString;
            if (connection != null)
            {
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 35));
                optionsBuilder.UseMySql(connection, serverVersion);
            }
            else
            {
                Console.WriteLine("MainConnection is null");
            }
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the Employee entity
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasMaxLength(64);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Surname)
                .HasMaxLength(64);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Position)
                .HasMaxLength(64);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Login)
                .HasMaxLength(64);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .HasMaxLength(64);

            // Define the Product entity
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(255);
            modelBuilder.Entity<Product>()
                .Property(p => p.Category)
                .HasMaxLength(64);
            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(1024);

            // Define the Invoice entity
            modelBuilder.Entity<Invoice>()
                .Property(i => i.Provider)
                .HasMaxLength(255);

            // Define the EmployeePermission entity
            modelBuilder.Entity<EmployeePermission>()
                .Property(ep => ep.Title)
                .HasMaxLength(64);

            // Define the ProductInvoice entity
            modelBuilder.Entity<ProductInvoice>()
                .HasKey(pi => new { pi.InvoiceId, pi.ProductId });

            // Define the ProductReceipt entity
            modelBuilder.Entity<ProductReceipt>()
                .HasKey(pr => new { pr.ReceiptId, pr.ProductId });

            // Define the SaleStatistic entity
            modelBuilder.Entity<SaleStatistic>()
                .HasOne(ss => ss.Product)
                .WithOne()
                .HasForeignKey<SaleStatistic>(ss => ss.SaleStatisticProductId)
                .HasPrincipalKey<Product>(p => p.Id);

            // Define the Action entity
            modelBuilder.Entity<Action>()
                .HasOne(a => a.Product)
                .WithOne()
                .HasForeignKey<Action>(a => a.ActionProductId)
                .HasPrincipalKey<Product>(p => p.Id);

            // Define relationships
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeePermission)
                .WithMany(ep => ep.Employees)
                .HasForeignKey(e => e.EmployeePermissionId);

            modelBuilder.Entity<EmployeeSession>()
                .HasOne(es => es.Employee)
                .WithMany(e => e.EmployeeSessions)
                .HasForeignKey(es => es.EmployeeId);

            modelBuilder.Entity<SaleStatistic>()
                .HasOne(ss => ss.Product)
                .WithOne()
                .HasForeignKey<SaleStatistic>(ss => ss.SaleStatisticProductId);

            modelBuilder.Entity<Action>()
                .HasOne(a => a.Product)
                .WithOne()
                .HasForeignKey<Action>(a => a.ActionProductId);

            modelBuilder.Entity<ProductInvoice>()
                .HasOne(pi => pi.Invoice)
                .WithMany(i => i.ProductInvoices)
                .HasForeignKey(pi => pi.InvoiceId);

            modelBuilder.Entity<ProductInvoice>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductInvoices)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductReceipt>()
                .HasOne(pr => pr.Receipt)
                .WithMany(r => r.ProductReceipts)
                .HasForeignKey(pr => pr.ReceiptId);

            modelBuilder.Entity<ProductReceipt>()
                .HasOne(pr => pr.Product)
                .WithMany(p => p.ProductReceipts)
                .HasForeignKey(pr => pr.ProductId);

            modelBuilder.Entity<ProductReceipt>()
                .HasOne(pr => pr.Action)
                .WithMany()
                .HasForeignKey(pr => pr.ActionId);
        }
    }
}