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
        [Route("Alumno/Index/{alumnoId}")]
        [Route("Alumno/Index")]
        public IActionResult Index(string alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno = from alum in _context.Alumnos
                                where alum.Id == alumnoId
                                select alum;
            return View( alumno.SingleOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
            
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