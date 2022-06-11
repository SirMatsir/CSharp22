//using FinalProject320.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace FinalProject320.Controllers
//{
//    public class MusicalObjectModel : Controller
//    {
//        [HttpGet]
//        public IActionResult SaveProduct()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult SaveProduct(IFormCollection formCollection)
//        {
//            using (var context = new Db.MusicInstrumentsContext())
//            {

//                var musicObj = new Models.MusicalObjectModel();

//                musicObj.Name = formCollection["Name"];
//                musicObj.Description = formCollection["Description"];
//                musicObj.Price = Convert.ToDecimal(formCollection["Price"]);
//                musicObj.Category = formCollection["Category"];
//                musicObj.ProductCount = Convert.ToInt32(formCollection["ProductCount"]);

//                var instrument = new Db.Gear();
//                instrument.Name = musicObj.Name;
//                instrument.Description = musicObj.Description;
//                instrument.Price = musicObj.Price;
//                instrument.Category = musicObj.Category;
//                instrument.ProductCount = musicObj.ProductCount;

//                context.Gears.Add(instrument);
//                context.SaveChanges();
//            }

//            return RedirectToAction("Index");
//        }
//    }
//}
