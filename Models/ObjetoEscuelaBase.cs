using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS_proyecto.Models;

public abstract class ObjetoEscuelaBase // Una clase abstracta no permite generar instancias de esta. Pero si heredar
    {
        public string? Id {get; set;}
        public virtual string? Nombre {get;set;}

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {Id}".ToString();
        }
    }
