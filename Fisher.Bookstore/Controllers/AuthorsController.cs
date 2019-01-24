using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Authors()
        {
            return Content("Here are some of the Authors I like.");
        }
        public IActionResult Featured()
        {
            return Content("The human who wrote Time Travelers Wife, the human who wrote All the MazeRunners. Thats about it.");
        }
       
    }
}