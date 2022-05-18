using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HomeworkAss2.Models;
using System.Linq;

namespace HomeworkAss2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index(string sortOrder)
        {
            var contacts = new[]
            {
                new Contact{Id = 1, Name="dave", City="Seattle", State="WA", Phone="123"},
                new Contact{Id = 2, Name="mike", City="Spokane", State="WA", Phone="234"},
                new Contact{Id = 3, Name="lisa", City="San Jose", State="CA", Phone="345"},
                new Contact{Id = 4, Name="cathy", City="Dallas", State="TX", Phone="456"},
            };

            ViewBag.SortIdBy = string.IsNullOrEmpty(sortOrder) ? "Id desc" : "";
            ViewBag.SortNameBy = sortOrder == "Name" ? "Name desc" : "Name";
            ViewBag.SortCityBy = sortOrder == "City" ? "City desc" : "City";
            ViewBag.SortStateBy = sortOrder == "State" ? "State desc" : "State";
            ViewBag.SortPhoneBy = sortOrder == "Phone" ? "Phone desc" : "Phone";


            if (sortOrder != null)
            {
                switch (sortOrder.ToLower())
                {
                    case "id":
                        {
                            // modify contacts to be ordered by Id
                            contacts = contacts.OrderBy(x => x.Id).ToArray();
                            break;
                        }
                    case "name desc":
                        {
                            contacts = contacts.OrderByDescending(x => x.Name).ToArray();
                            break;
                        }
                    case "name":
                        {
                            contacts = contacts.OrderBy(x => x.Name).ToArray();
                            break;
                        }
                    case "city desc":
                        {
                            contacts = contacts.OrderByDescending(x => x.City).ToArray();
                            break;
                        }
                    case "city":
                        {
                            contacts = contacts.OrderBy(x => x.City).ToArray();
                            break;
                        }
                    case "state desc":
                        {
                            contacts = contacts.OrderByDescending(x => x.State).ToArray();
                            break;
                        }
                    case "state":
                        {
                            contacts = contacts.OrderBy(x => x.State).ToArray();
                            break;
                        }
                    case "phone desc":
                        {
                            contacts = contacts.OrderByDescending(x => x.Phone).ToArray();
                            break;
                        }
                    case "phone":
                        {
                            contacts = contacts.OrderBy(x => x.Phone).ToArray();
                            break;
                        }
                        default:
                        {
                            contacts = contacts.OrderBy(x => x.Id).ToArray();
                            break;
                        }
                }
            }

            return View(contacts);
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
    }
}