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
            return View( new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            });
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>()
            {
                            new Asignatura{Nombre="Matemáticas",
                                UniqueId= Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                                UniqueId= Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId= Guid.NewGuid().ToString()
                            }
                            ,
                            new Asignatura{Nombre="Programación",
                                UniqueId= Guid.NewGuid().ToString()
                            }

            };
            return View("Multiasignatura", listaAsignaturas);
        }
    }
}