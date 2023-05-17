using Microsoft.EntityFrameworkCore;

namespace Restaurants.Models
{
  public class RestaurantsContext : DbContext
  {
    public DbSet<Cuisine> Cuisine { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }

    public RestaurantsContext(DbContextOptions options) : base(options) { }
  }
}