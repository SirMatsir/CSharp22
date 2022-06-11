using FinalProject320.V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;// Add this to the top for EF
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using FinalProject320.V2.Db;
using System.Collections;

namespace FinalProject320.V2.Controllers
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

        public IActionResult Index()
        {

            var model = new IndexModel();
            model.GearItems = (IList<GearItem>)_context.Gears.ToList();
            return View(model);

            //MusicInstrumentsDBContext context = new MusicInstrumentsDBContext();
            //List<MusicalObjectModel> instruments = context.MusicalObjectModels.ToList();

            //var musicObj = new MusicalObjectModel();
            //foreach (MusicalObjectModel gear in instruments)
            //{
            //    musicObj.Name = gear.Name;
            //    musicObj.Description = gear.Description;
            //    musicObj.Price = gear.Price;
            //    musicObj.Category = gear.Category;
            //    musicObj.ProductCount = gear.ProductCount;
            //}

            //if (context.Gears.Any())
            //{
            //    foreach (var x in context.Gears)
            //    {
            //        musicObj.Name = gear.Name;
            //        musicObj.Description = gear.Description;
            //        musicObj.Price = gear.Price;
            //        musicObj.Category = gear.Category;
            //        musicObj.ProductCount = gear.ProductCount;
            //    }

            //}


            //ViewBag.SortIdBy = string.IsNullOrEmpty(sortOrder) ? "Id desc" : "";
            //ViewBag.SortNameBy = sortOrder == "Name" ? "Name desc" : "Name";
            //ViewBag.SortDescriptionBy = sortOrder == "Description" ? "Description desc" : "Description";
            //ViewBag.SortPriceBy = sortOrder == "Price" ? "Price desc" : "Price";
            //ViewBag.SortCategoryBy = sortOrder == "Category" ? "Category desc" : "Category";
            //ViewBag.SortProductCountBy = sortOrder == "ProductCount" ? "ProductCount desc" : "ProductCount";


            //    if (sortOrder != null)
            //    {
            //        switch (sortOrder.ToLower())
            //        {
            //            case "name desc":
            //                {
            //                // modify contacts to be ordered by Id
            //                context.Gears = context.Gears.OrderByDescending(x => x.Id).ToArray;
            //                    break;
            //                }
            //            case "name desc":
            //                {
            //                    contacts = contacts.OrderByDescending(x => x.Name).ToArray();
            //                    break;
            //                }
            //            case "name":
            //                {
            //                    contacts = contacts.OrderBy(x => x.Name).ToArray();
            //                    break;
            //                }
            //            case "city desc":
            //                {
            //                    contacts = contacts.OrderByDescending(x => x.City).ToArray();
            //                    break;
            //                }
            //            case "city":
            //                {
            //                    contacts = contacts.OrderBy(x => x.City).ToArray();
            //                    break;
            //                }
            //            case "state desc":
            //                {
            //                    contacts = contacts.OrderByDescending(x => x.State).ToArray();
            //                    break;
            //                }
            //            case "state":
            //                {
            //                    contacts = contacts.OrderBy(x => x.State).ToArray();
            //                    break;
            //                }
            //            case "phone desc":
            //                {
            //                    contacts = contacts.OrderByDescending(x => x.Phone).ToArray();
            //                    break;
            //                }
            //            case "phone":
            //                {
            //                    contacts = contacts.OrderBy(x => x.Phone).ToArray();
            //                    break;
            //                }
            //            default:
            //                {
            //                    contacts = contacts.OrderBy(x => x.Id).ToArray();
            //                    break;
            //                }
            //        }

            //return View();
        }

        public IActionResult Details(int id)
        {
            MusicInstrumentsContext musicInstrumentsContext = new MusicInstrumentsContext();
            Gear gear = musicInstrumentsContext.Gears.Single(inst => inst.Id == id);

            return View(gear);
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
        public IActionResult SaveProduct(IFormCollection formCollection)
        {
            using (var context = new MusicInstrumentsContext())
            {

                var musicObj = new MusicalObjectModel();

                musicObj.Name = formCollection["Name"];
                musicObj.Description = formCollection["Description"];
                musicObj.Price = Convert.ToDecimal(formCollection["Price"]);
                musicObj.Category = formCollection["Category"];
                musicObj.ProductCount = Convert.ToInt32(formCollection["ProductCount"]);

                var instrument = new Db.Gear();
                instrument.Name = musicObj.Name;
                instrument.Description = musicObj.Description;
                instrument.Price = musicObj.Price;
                instrument.Category = musicObj.Category;
                instrument.ProductCount = musicObj.ProductCount;

                context.Gears.Add(instrument);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        //edit MusicalObject already in sql db

        //delete MusicalObject from sql db

        //search MusicalObject in sql db

        //list sql db of MusicalObject
    }
}