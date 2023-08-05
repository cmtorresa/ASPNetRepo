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
        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

            curso.EscuelaId = escuela.Id;
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            ViewBag.MensajeExtra = "Curso Creado"
            return View("Index", curso);
            }
            else
            {
                return View(curso)
            }
        }

        public IActionResult Update(string id)
        {
            var curso = from cur in _context.Cursos
                            where cur.id == id
                            select cur;
            return view(curso.SingleOrDefault());
        }


        [Route("Curso/Update")]
        [Route("Curso/Update/{cursoId}")]
        [HttpPUT]
        public IActionResult Update(Curso cursoUpdate, string id)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var cursoBuscado = from cur in _context.Cursos
                                        where cur.id==id
                                        select cur;
                var cursillo = cursoBuscado.SingleOrDefault();
                cursillo.Direccion = cursoUpdate.Direccion;
                cursillo.Nombre = cursoUpdate.Nombre;
                cursillo.Jornada=cursoUpdate.Jornada;
                _context.SaveChanges();
            ViewBag.MensajeExtra = "Curso Actualizado"
            return View("Index", cursoUpdate);
            }
            else
            {
                return View(cursoUpdate)
            }
        }

        [Route("Curso/Delete")]
        [Route("Curso/Delete/{cursoId}")]
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var curso = from cur in _context.Cursos
                            where cur.id == id
                            select cur;

            _context.Cursos.Remove(curso.FirstOrDefault());
            _context.SaveChanges();
            ViewBag.MensajeExtra = "Curso Eliminado"
            return view("Multicurso");
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