using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Persona
    {
        
        public int PersonaId { get; set; }
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Telefono {get;set;}
        public string FechaNacimiento {get;set;}

    }
}