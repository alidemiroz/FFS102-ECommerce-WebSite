using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FFS102_Ecommerce_Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Approve()
        {
            return View();
        }
    }
}