using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure;

public class ProductClientHubDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "Server=localhost;Database=ProductClientHub;User=root;Password=12041995",
            new MySqlServerVersion(new Version(8, 0, 40)));
    }
}