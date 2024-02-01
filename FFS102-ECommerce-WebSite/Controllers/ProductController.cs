using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FFS102_ECommerce_WebSite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Comment()
        {
            return View();
        }
    }
}