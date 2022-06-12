//using FinalProject320.Db;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace FinalProject320.Controllers
//{
//    public class Search : Controller
//    {
//        private readonly ILogger<HomeController> _logger;
//        private readonly MusicInstrumentsContext _context;

//        public Search(ILogger<HomeController> logger, MusicInstrumentsContext context)
//        {
//            _logger = logger;
//            _context = context;
//        }
        
//        public async Task<IActionResult> Index(string searchStr)
//        {
//            using (var context = new MusicInstrumentsContext())
//            { 
//                var model = from m in context.Gears
//                        select m;

//            if (!string.IsNullOrEmpty(searchStr))
//            {
//                model = model.Where(inst => inst.Name!.Contains(searchStr));
//            }

//            return View(await model.ToListAsync());
//            }
//        }
//        //[HttpPost]
//        //public string Index(string searchStr, bool notUsed)
//        //{
//        //    return "From [HttpPost]Index: filter on " + searchStr;
//        //}
//    }
//}
