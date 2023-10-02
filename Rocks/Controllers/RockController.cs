using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Rocks.Models;

namespace Rocks.Controllers
{
    public class RockController : Controller
    {
        private RockContext context;
        public RockController(RockContext ctx) {
            context = ctx;
        }
        public IActionResult Add()
        {
            return View("Edit") ;
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
