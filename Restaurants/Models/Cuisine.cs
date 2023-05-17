using System.Collections.Generic;

namespace Restaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Type { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  

    public Cuisine(string type)
    {
    Type = type;
    }

  }
}