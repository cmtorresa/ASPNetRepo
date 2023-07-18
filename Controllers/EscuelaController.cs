using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APS_proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace APS_proyecto.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.YearF=2005;
            escuela.EscuelaId=Guid.NewGuid().ToString();
            escuela.Nombre="Platzi School";
            return View(escuela);
        }
    }
}