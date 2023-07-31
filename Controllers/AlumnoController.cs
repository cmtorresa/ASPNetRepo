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
   public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View( _context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno", _context.Alumnos);
        }
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}