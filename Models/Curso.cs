using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APS_proyecto.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        // [Required]
        public override string Nombre {get; set;}
        public TiposJornada Jornada {get;set;}
        public List<Asignatura> Asignaturas {get;set;}
        public List<Alumno> Alumnos {get;set;}

        // [Required(ErrorMessage="Se requiere Incluir una dirección")]
        // [Display(prompt="Dir. Correspondencia", Nombre = "Address")]
        // [MinLenght(10, ErrorMessage="La Longitud requerida es mayor a 10 Chr")]
        public string Direccion { get ; set ; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }

    
}