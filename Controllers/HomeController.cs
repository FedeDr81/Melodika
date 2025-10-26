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

    public IActionResult CancionesPopulares()
    {
        return View("CancionesPopulares");
    }


    public IActionResult CrearCuenta()
    {
        return View("CrearCuenta");
    }


    public IActionResult CrearUsuario()
    {
        return View("CrearUsuario");
    }


    public IActionResult Cursos()
    {
        return View("Cursos");
    }


        public IActionResult ElegirUsuario()
    {
        return View("ElegirUsuario");
    }


        public IActionResult LogrosYRecompensas()
    {
        return View("LogrosYRecompensas");
    }
        public IActionResult FAQ()
    {
        return View("PreguntasFrecuentes");
    }


}
