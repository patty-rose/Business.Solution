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
        new Shop { ShopId = 5, Name = "Babydoll Pizza", ShopType = "Restaurant", TypeCategory = "Pizza" },
        new Shop { ShopId = 6, Name = "New Seasons", ShopType = "Store", TypeCategory = "Grocery" },
        new Shop { ShopId = 7, Name = "JoJo's", ShopType = "Restaurant", TypeCategory = "Fried Chicken" },
        new Shop { ShopId = 8, Name = "People's Food Coop", ShopType = "Store", TypeCategory = "Grocery" },
        new Shop { ShopId = 9, Name = "Academy", ShopType = "Theater", TypeCategory = "Film" },
        new Shop { ShopId = 10, Name = "Arlene Schintzer", ShopType = "Concert Hall", TypeCategory = "Music" },
        new Shop { ShopId = 11, Name = "The Laurelhurst Theater", ShopType = "Theater", TypeCategory = "Film" }
      );
    }
  }
}