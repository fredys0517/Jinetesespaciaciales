using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Mantenimiento

    {
        
        public int IdMantenimiento { get; set; }
        public string NivelAceite {get;set;}
        public string NivelLiquidoFrenos {get;set;}
        public string NivelRefrigerante {get;set;}
        public string NivelLiquidoDireccion {get;set;}
        public string FechaMantenimiento {get;set;}
        public Vehiculo FkIdVehiculo {get;set;}

    }
}