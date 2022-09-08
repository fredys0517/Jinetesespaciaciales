using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Propietario:Persona
    {
        
        public int IdPropietario { get; set; }
        public Persona IdPersona {get;set;}
        public string CiudadResidencia {get;set;}
        public string Correo {get;set;}
       

    }
}