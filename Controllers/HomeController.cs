using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using melodika.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
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


/*
        public IActionResult LoginGuardar(string correo, string contraseña)
    {
        int idUser = BD.logIn(correo, contraseña);
        if(idUser >= 0){
            Cuenta cuentaLogueada;
            cuentaLogueada = BD.getCuenta();
            string usuario = Objeto.ObjectToString(cuentaLogueada);
            HttpContext.Session.SetString("usuario", Objeto. ObjectToString (usuario));
            return View("Cursos"); 
        }
        else if(idUser == -1){
            ViewBag.mensaje("La contraseña o el usuario estan mal");
            return View("login");
        }
        else if (HttpContext.Session.GetString("idUsuario") != null)
        {
            ViewBag.mensaje = "Ya hay un usuario logueado. Para ingresar denuevo primero salga de sesion";
            return View("login");
        }
        return View("login");

    }
*/
    public IActionResult Configuracion()
    {
        return View("Configuracion");
    }

    

    public IActionResult CancionesPopulares()
    {
        List<Cancion> canciones = new List<Cancion>();
        canciones = BD.seleccionarCancion();
        ViewBag.canciones = canciones;
        return View("CancionesPopulares");
    }


    public IActionResult CrearCuenta()
    {

        return View("CrearCuenta");
    }

        public IActionResult CrearCuentaGuardar(string correo, string contra1, string contra2, string username)
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
        public IActionResult PreguntasFrecuentes()
    {
        return View("PreguntasFrecuentes");
    }


}
