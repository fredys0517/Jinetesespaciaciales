using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Vehiculo
    {
        
        public int IdVehiculo { get; set; }
        public string Placa {get;set;}
        public string TipoVehiculo {get;set;}
        public string Marca {get;set;}
        public string Pasajero {get;set;}
        public string Cilindraje {get;set;}
        public string PaisOrigen {get;set;}
        public string CaracteristicasExtra {get;set;}
        public string FkIdMecanico {get;set;}
        public string FkIdPropietario {get;set;}

    }
}