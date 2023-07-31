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
            return View( _context.Asignaturas.FirstOrDefault());
        }
        public IActionResult MultiAsignatura()
        {
            return View("Multiasignatura", _context.Asignaturas);
        }
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}