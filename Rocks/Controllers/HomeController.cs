using Microsoft.AspNetCore.Mvc;
using Rocks.Models;
//using Rocks.Models;
using System.Diagnostics;
using System.Linq;

namespace Rocks.Controllers
{
    public class HomeController : Controller
    {
        private RockContext context { get; set; }
        public HomeController(RockContext ctx) {
            context = ctx;
        }

        public IActionResult Index()
        {
            var rocks = context.Rocks.ToList();
            return View(rocks);
        }
    }
}