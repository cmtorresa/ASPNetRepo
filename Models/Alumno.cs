using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS_proyecto.Models

{
    public class Alumno:ObjetoEscuelaBase
    {
       public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();// Inicializar la lista desde aqui.

    }
    
}