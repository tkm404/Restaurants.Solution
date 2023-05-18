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
      List<Restaurant> model = _db.RestaurantSA
                                  .Include(restaurant => restaurant.Cuisine)
                                  .ToList();
      return View(model);
    }

      public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      if (restaurant.CuisineId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.RestaurantSA.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  public ActionResult Edit(int id)
  {
    Restaurant thisRestaurant = _db.RestaurantSA.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
    return View(thisRestaurant);
  }

  [HttpPost]
  public ActionResult Edit(Restaurant restaurant)
  {
    _db.RestaurantSA.Update(restaurant);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }

  public ActionResult Details(int id)
  {
    Restaurant thisRestaurant = _db.RestaurantSA
                                    .Include(restaurant => restaurant.Cuisine)
                                    .FirstOrDefault(restaurant => restaurant.RestaurantId == id);
    return View(thisRestaurant);
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