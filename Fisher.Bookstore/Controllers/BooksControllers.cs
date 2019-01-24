using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Books()
        {
            return Content("Here are some of the books I like.");
        }
        public IActionResult New()
        {
            return Content("Time Travelers Wife, All the MazeRunners. Thats about it.");
        }
        public IActionResult BestSellers()
        {
            return Content("Time Travelers Wife.");
        }
    }
}