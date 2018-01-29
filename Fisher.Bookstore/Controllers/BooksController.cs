using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        [Route("/books")]
        public IActionResult Index()
        {
            return Content("books");
        }
        [Route("/books/new")]
        public IActionResult New()
        {
            return Content("new books");
        }
    }
}