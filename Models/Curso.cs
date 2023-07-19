using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APS_proyecto.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada {get;set;}
        public List<Asignatura> Asignaturas {get;set;}
        public List<Alumno> Alumnos {get;set;}
        public string Direccion { get ; set ; }

    }

    
}