using Microsoft.EntityFrameworkCore;
using PurchaseManagementSystem.Models;

namespace PurchaseManagementSystem.DataContext
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Issuance> Issuance { get; set; }
    }
}
