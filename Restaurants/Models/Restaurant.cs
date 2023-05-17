using System.Collections.Generic;

namespace Restaurants.Models
{
  public class Restaurant
  {
    public int CuisineId { get; set; }
    public Cuisine Cuisine { get; set; }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string PriceTier { get; set; }
    public string Style { get; set; }
    public int Smoking { get; set; }
    public int Alcohol { get; set; }


    public Restaurant(string name, string priceTier, string style, int smoking, int alcohol)
    {
      Name = name;
      PriceTier = priceTier;
      Style = style;
      Smoking = smoking;
      Alcohol = alcohol; 
    
    }

  }
}