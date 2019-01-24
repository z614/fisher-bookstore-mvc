using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("I worked for about 2 hours on this.");
        }
        public IActionResult History()
        {
            return Content("Made at around 8pm on 1/23/19.");
        }
        public IActionResult Location()
        {
            return Content("Made in the RPAC.");
        }
    }
}