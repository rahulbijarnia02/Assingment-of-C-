using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Registration(Registration model)
    {
        if(ModelState.IsValid){

        }
        TempData["Message"]="Record saved succesfully";
        model=new Registration();
        return View(model);
    }
[Authorize("Read")]
public IActionResult Read()
{
    return View();
}
[Authorize("Write")]
public IActionResult Edit()
{
    return View();
}

[CacheResource]
public class CachedController : Controller
{
    public IActionResult Index()
    {
        return Content("This content was generated at " + DateTime.Now);
    }
}
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
