using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorController : Controller
    {
        [Route("/authors")]
        public IActionResult Index()
        {
            return Content("authors");
        }
        [Route("/authors/featured")]
        public IActionResult Featured()
        {
            return Content("featured authors");
        }
    }
}