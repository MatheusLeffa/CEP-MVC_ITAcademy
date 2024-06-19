using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_Controller.Models;

namespace _01_Controller.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Razor01(){
        return View();
    }
    public IActionResult Index()
    {        
        return View();
    }

    public IActionResult Index2(string id)
    {   
        ViewData["nome"] = id;
        ViewBag.UmaPalavra="Dell IT Academy";
        
        return View("Index");
    }

    public IActionResult Index3(int valor)
    {   
        ViewData["nome"] = valor;
        ViewBag.UmaPalavra="Dell IT Academy";
        
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
