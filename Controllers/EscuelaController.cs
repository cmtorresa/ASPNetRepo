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
            var escuela=_context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        private EscuelaContext _context;
        public EscuelaController (EscuelaContext context)
        {
            _context = context;
        }
    }
}