using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace Restaurants.Controllers
{
  public class RestaurantController : Controller
  {
    private readonly RestaurantsContext _db;

    public RestaurantController(RestaurantsContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Category> model = _db.Restaurant.ToList();
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //   return View();
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