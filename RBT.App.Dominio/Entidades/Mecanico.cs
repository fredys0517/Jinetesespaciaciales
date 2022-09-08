using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Mecanico:Persona
    {
        public int IdMecanico {get;set;}
        public Persona FkIdPersona { get; set; }
        public string Direccion {get;set;}
        public string NivelEstudios {get;set;}
        

    }
}