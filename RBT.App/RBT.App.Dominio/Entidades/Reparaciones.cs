using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Reparaciones
    {
        
        public int IdReparaciones { get; set; }
        public string FechaReparacion {get;set;}
        public string RepuestosCambiados {get;set;}
        public Mantenimiento FkIdMantenimiento {get;set;}
       

    }
}