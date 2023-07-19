using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APS_proyecto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APS_proyecto.Controllers
{
   public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura 
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre= " Programación"

            };
            return View(asignatura);
        }
    }
}