using Microsoft.EntityFrameworkCore;

namespace Business.Models
{
  public class BusinessContext : DbContext
  {
    public BusinessContext(DbContextOptions<BusinessContext> options) : base(options)
    {

    }

    public DbSet<Shop> Shops { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
      .HasData(
        new Shop { ShopId = 1, Name = "Powells", ShopType = "Store", TypeCategory = "Books" },
        new Shop { ShopId = 2, Name = "Doe Donuts", ShopType = "Restaurant", TypeCategory = "Donuts" },
        new Shop { ShopId = 3, Name = "Mississippi Records", ShopType = "Shop", TypeCategory = "Music" },
        new Shop { ShopId = 4, Name = "Green Zebra", ShopType = "Store", TypeCategory = "Grocery" },
        new Shop { ShopId = 5, Name = "Babydoll Pizza", ShopType = "Restaurant", TypeCategory = "Pizza" }
      );
    }
  }
}