using Billing.BillingAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Billing.BillingAPI.Infrastructure.Data
{
    public class BillingDbContext : DbContext
    {
        public BillingDbContext (DbContextOptions<BillingDbContext> options) { }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employee { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<InvoiceItem> InvoicesItem { get; set; } = null!;
        public DbSet<CompanyProfile> CompanyProfiles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BillingDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
