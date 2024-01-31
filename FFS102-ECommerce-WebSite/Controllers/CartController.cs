using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FFS102_ECommerce_WebSite.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}