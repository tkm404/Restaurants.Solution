using Microsoft.EntityFrameworkCore;

namespace Restaurants.Models
{
  public class RestaurantsContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> RestaurantSA { get; set; }

    public RestaurantsContext(DbContextOptions options) : base(options) { }
  }
}