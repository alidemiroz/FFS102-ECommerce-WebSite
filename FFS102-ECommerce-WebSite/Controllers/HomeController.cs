using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FFS102_ECommerce_WebSite.Models;

namespace FFS102_ECommerce_WebSite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Listing()
    {
        return View();
    }

    public IActionResult ProductDetail()
    {
        return View();
    }
}

