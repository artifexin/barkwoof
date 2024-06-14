using core.Entities;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data
{
    public class StoreContext : DbContext
    {
#pragma warning disable IDE0290 // Use primary constructor
public StoreContext(DbContextOptions options) : base(options)
#pragma warning restore IDE0290 // Use primary constructor
{
    
}
public DbSet<Product> Products { get; set; }
    }
}