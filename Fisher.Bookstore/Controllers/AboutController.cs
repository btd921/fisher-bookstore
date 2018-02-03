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
            return View();
        }
        [Route("about/history")]
        public IActionResult History()
        {
            return View();
        }
        [Route("about/location")]
        public IActionResult Location()
        {
            return View();
        }
    }

}