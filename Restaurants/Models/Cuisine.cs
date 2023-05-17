using System.Collections.Generic;

namespace Restaurants.Models
{
  public class Cuisine
  {
    public string Type { get; set; }
    public List<Restaurant> Restaurants { get; set; }
    public int CuisineId { get; set; }

    public Cuisine(string type)
    {
    Type = type;
    }

  }
}