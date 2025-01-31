using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infrastructure;

public class ProductClientHubDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;

    public ProductClientHubDbContext(DbContextOptions<ProductClientHubDbContext> options) : base(options) { }

    public ProductClientHubDbContext()
    {
        throw new NotImplementedException();
    }
}