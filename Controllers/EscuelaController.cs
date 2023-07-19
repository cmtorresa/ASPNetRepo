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
            escuela.FundationYear=2005;
            escuela.UniqueId=Guid.NewGuid().ToString();
            escuela.Nombre="Platzi School";
            escuela.Country = "Colombia";
            escuela.City = "Bogotá";
            escuela.TipoEscuela = TiposEscuela.secundaria;
            escuela.Direccion = "Av. Siempre viva";
            return View(escuela);
        }
    }
}