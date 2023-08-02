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
        [Route("Asignatura/Index/{asignaturaId}")]
        [Route("Asignatura/Index")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                where asig.Id == asignaturaId
                                select asig;
            return View( asignatura.SingleOrDefault());
            }
            else
            {
                return View("Multiasignatura", _context.Asignaturas);
            }
            
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