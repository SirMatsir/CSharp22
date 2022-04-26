using HomeworkAssign1.Models;
using HomeworkAss1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeworkAss1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult BirthdayCardForm()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Thanks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BirthdayCardForm(BirthdayCard birthdayCard)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", birthdayCard);
            }
            else
            {
                return View();
            }
        }

    }
}