using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;

public class HomeController : Controller
{

    // Action method for the home page
    public IActionResult Index()
    {
        return View();
    }
    // Action method for the privacy page
    public IActionResult Privacy()
    {
        return View();
    }
    // Action method for handling errors
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
