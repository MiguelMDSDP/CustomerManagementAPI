using Microsoft.EntityFrameworkCore;
using CustomerManagementAPI.Models;

namespace CustomerManagementAPI.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Customer>? Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionString = "server=localhost;user=root;password=pass;database=customer-management-db";
      var serverVersion = new MySqlServerVersion(new Version(8, 0, 1));
      optionsBuilder.UseMySql(connectionString, serverVersion);
    }
  }
}