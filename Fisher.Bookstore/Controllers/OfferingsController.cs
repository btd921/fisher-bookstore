using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Fisher.Bookstore.Controllers
{
    public class OfferingsController : Controller
    {
        [Route("products")]
        [Route("producesAttribute/Index")]
        public IActionResult Products()
        {
            return View("Products");
        }

        [Route("services")]
        [Route("services/Index")]
        public IActionResult Services()
        {
            return View("services");
        }
    }
}