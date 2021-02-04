using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavidWeb.Controllers
{
    public class ConstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearPersona(string nombre, string apellido, string cedula, string ocupacion, string lugarTrabajo, string horario)
        {
            var restulado ="";
            ViewBag.Persona = restulado;
            return View();
        }
    }
}
