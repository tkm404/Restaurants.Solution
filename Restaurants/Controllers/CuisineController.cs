using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restaurants.Controllers
{
  public class CuisineController : Controller
  {
    private readonly RestaurantsContext _db;

    public CuisineController(RestaurantsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
        List<Cuisine> model = _db.Cuisine.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
        _db.Cuisine.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisine
                                  .Include(cuisine => cuisine.Restaurants)
                                  .FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(thisCuisine);
    }
  }
}