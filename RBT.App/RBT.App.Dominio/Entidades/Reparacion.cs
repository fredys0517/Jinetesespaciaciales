using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Reparacion
    {
        
        public int ReparacionId { get; set; }
        public string FechaReparacion {get;set;}
        public string RepuestosCambiados {get;set;}
        public Mantenimiento Mantenimiento {get;set;} // llave foranea
       

    }
}