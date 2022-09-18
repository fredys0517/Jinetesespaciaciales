using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Reparacion
    {
        
        public int Id { get; set; }
        public string? FechaReparacion {get;set;}
        public string? RepuestosCambiados {get;set;}
        public Mantenimiento mantenimiento {get;set;} // llave foranea
       

    }
}