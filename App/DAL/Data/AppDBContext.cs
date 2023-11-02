using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = ConfigurationManager.ConnectionStrings["MainConnection"].ToString();
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

    }
}
