using FinalProject320.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;// Add this to the top for EF
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using FinalProject320.Db;
using System.Collections;

namespace FinalProject320.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicInstrumentsContext _context;

        public HomeController(ILogger<HomeController> logger, MusicInstrumentsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string sortOrder)
        {
            using (var context = new MusicInstrumentsContext())
            {

            ViewBag.SortNameBy = string.IsNullOrEmpty(sortOrder) ? "Name desc" : "";
            ViewBag.SortDescriptionBy = sortOrder == "Description" ? "Description desc" : "Description";
            ViewBag.SortPriceBy = sortOrder == "Price" ? "Price desc" : "Price";
            ViewBag.SortCategoryBy = sortOrder == "Category" ? "Category desc" : "Category";
            ViewBag.SortProductCountBy = sortOrder == "ProductCount" ? "ProductCount desc" : "ProductCount";


                var model = new IndexModel();
                model.GearItems = context.Gears.ToList();
                
                if (sortOrder == null)
                {
                    sortOrder = "";
                }
                switch (sortOrder.ToLower())
                {
                    case "name desc":
                        model.GearItems = context.Gears.OrderByDescending(x => x.Name).ToList();
                        break;

                    case "description":
                        model.GearItems = context.Gears.OrderBy(x => x.Description).ToList();
                        break;

                    case "description desc":
                        model.GearItems = context.Gears.OrderByDescending(x => x.Description).ToList();
                        break;

                    case "price":
                        model.GearItems = context.Gears.OrderBy(x => x.Price).ToList();
                        break;

                    case "price desc":
                        model.GearItems = context.Gears.OrderByDescending(x => x.Price).ToList();
                        break;

                    case "category":
                        model.GearItems = context.Gears.OrderBy(x => x.Category).ToList();
                        break;

                    case "category desc":
                        model.GearItems = context.Gears.OrderByDescending(x => x.Category).ToList();
                        break;

                    case "productcount":
                        model.GearItems = context.Gears.OrderBy(x => x.ProductCount).ToList();
                        break;

                    case "productcount desc":
                        model.GearItems = context.Gears.OrderByDescending(x => x.ProductCount).ToList();
                        break;

                    default:
                        model.GearItems = context.Gears.OrderBy(x => x.Name).ToList();
                        break;

                }
                

                return View(model);
            }

        }
        public IActionResult Delete(int id)
        {
            using (var context = new MusicInstrumentsContext())
            {
                context.Gears.Remove(context.Gears.Single(inst => inst.Id == id));
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            MusicInstrumentsContext context = new MusicInstrumentsContext();
            IQueryable<Gear> gears = context.Gears.Where(inst => inst.Name.Contains(search));

            return View(gears);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SaveProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveProduct(Gear gear)
        {
            using (var context = new MusicInstrumentsContext())
            {
                var instrument = new Gear();
                instrument.Name = gear.Name;
                instrument.Description = gear.Description;
                instrument.Price = Convert.ToDecimal(gear.Price);
                instrument.Category = gear.Category;
                instrument.ProductCount = Convert.ToInt32(gear.ProductCount);

                if (ModelState.IsValid)
                {
                    context.Gears.Add(instrument);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            } 
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            MusicInstrumentsContext context = new MusicInstrumentsContext();
            Gear gear = context.Gears.Single(inst => inst.Id == id);

            return View(gear);
        }

        [HttpPost]
        public IActionResult EditProduct(Gear gear)
        {
            using (var context = new MusicInstrumentsContext())
            {
                int id = Convert.ToInt32(gear.Id);
                var instrument = context.Gears.Single(inst => inst.Id == id);
                instrument.Name = gear.Name;
                instrument.Description = gear.Description;
                instrument.Price = Convert.ToDecimal(gear.Price);
                instrument.Category = gear.Category;
                instrument.ProductCount = Convert.ToInt32(gear.ProductCount);

                // validate form data
                if (ModelState.IsValid)
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }
        //TADAH!
    }
}