using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FFS102_Ecommerce_Admin.Models;

namespace FFS102_Ecommerce_Admin.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

