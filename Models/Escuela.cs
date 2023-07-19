using System.Collections.Generic;

namespace APS_proyecto.Models; 

public class Escuela:ObjetoEscuelaBase
    {

        string? name;
        /*
        La siguiente propiedad se quita porque hereda de ObjetoEscuelaBase
        public string Name 
        {
            get {return "Copia de: " + name;} //De esta forma alguien podria preguntar por nombre. Pero no asignarlo.
            set {name=value.ToUpper();} // de esta forma pongo el nombre en mayuscula.
        }*/

        public int FundationYear {get;set;} // Hace lo mismo que la parte de arriba

        public string? Country { get; set; }

        public string? City { get; set; }

        public TiposEscuela TipoEscuela {get;set;}

        public List<Curso> Cursos {get;set;} // Este se cambia a lista, se genera el using.collection generic con .+ctrl
        public string Direccion { get; set; }

        /*public Escuela(string name, int year)
        {
            this.name = name; // El primer name,luego del trhis es miembro de la clase
            FundationYear = year;
        }*/

        public Escuela(string name, int year) => (Nombre, FundationYear) = (name, year); // Sintaxis del método constructor abreviado

        public Escuela(string name, int year, TiposEscuela tipo, string pais="", string ciudad="") 
        {
           (Nombre, FundationYear) = (name, year);
           Country=pais;
           City=ciudad; //Similar a this.ciudad=ciudad;... en esto hago referencia de la clase City, no de la propiedad del constructor.    
        }

        public Escuela()
        {
            
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo Escuela: {TipoEscuela} \nPaís: {Country}, Ciudad: {City}";
        }
    }

