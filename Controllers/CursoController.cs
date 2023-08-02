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
   public class CursonController : Controller
    {
        [Route("Curso/Index/{cursoId}")]
        [Route("Curso/Index")]
        public IActionResult Index(string cursoId)
        {
            if (!string.IsNullOrWhiteSpace(cursoId))
            {
                var curso = from curs in _context.Cursos
                                where curs.Id == cursoId
                                select curs;
            return View( curso.SingleOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
            
        }

        public IActionResult MultiCurso()
        {
            return View("MultiCurso", _context.Cursos);
        }
        private EscuelaContext _context;
        public CursonController(EscuelaContext context)
        {
            _context = context;
        }
    }
}