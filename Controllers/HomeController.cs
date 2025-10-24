using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Melodika.Models;

namespace Melodika.Controllers;

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

        public IActionResult todasLasPaginas()
    {
        return View("allPages");
    }

    public IActionResult Login()
    {
        return View("login");
    }

        public IActionResult Configuracion()
    {
        return View("Configuracion");
    }

}
