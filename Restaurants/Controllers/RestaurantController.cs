using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restaurants.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly RestaurantsContext _db;

    public RestaurantController(RestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurant
                                            .Include(restaurant => restaurant.Cuisine)
                                            .ToList();
      return View(model);
    }

      public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {

      _db.Restaurant.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


    // public ActionResult New()
    // {
    //   ViewBag.Style = new SelectList(_db.Restaurant.Style, "Style", "Name")
    // }

    // [HttpPost]
    // public ActionResult Create(Category category)
    // {
    //   _db.Categories.Add(category);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}