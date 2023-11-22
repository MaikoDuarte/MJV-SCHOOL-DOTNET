using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aula_Dependency_injection.Models;

namespace Aula_Dependency_injection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private LoteriaLogica _loteria;

    public HomeController(ILogger<HomeController> logger, LoteriaLogica loteria)
    {
        _logger = logger;
        _loteria = _loteria;
    }

    public IActionResult Index()
    {
        LoteriaLogica.JogoLoteria();
        return RedirectToAction("Index");
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