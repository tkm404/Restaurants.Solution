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
            List<Cuisine> model = _db.Cuisines.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Cuisine cuisine)
        {
        
          // string type = cuisine.Type;
          // Cuisine compareCuisine = _db.Cuisine
          //                             // .Include(cuisine => cuisine.Type)
          //                             .FirstOrDefault(cuisine => cuisine.Type == type);
          // if (type == compareCuisine.Type)
          // {
          //   return RedirectToAction("Index");
          // }
          // else
          // {
          _db.Cuisines.Add(cuisine);
          _db.SaveChanges();
          // }
            return RedirectToAction("Index");
          }

        public ActionResult Details(int id)
        {
            Cuisine thisCuisine = _db.Cuisines
                                        .Include(cuisine => cuisine.Restaurants)
                                        .FirstOrDefault(cuisine => cuisine.CuisineId == id);
            return View(thisCuisine);
        }
    }
}