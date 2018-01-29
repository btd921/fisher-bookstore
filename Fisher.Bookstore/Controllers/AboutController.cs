using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        [Route("about")]
        [Route("about/index")]
        public IActionResult Index()
        {
            return Content("about index");
        }
        [Route("about/history")]
        public IActionResult History()
        {
            return Content("history");
        }
        [Route("about/location")]
        public IActionResult Location()
        {
            return Content("location");
        }
    }

}