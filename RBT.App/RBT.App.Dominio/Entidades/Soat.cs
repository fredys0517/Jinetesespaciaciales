using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Soat

    {
        
        public int Id { get; set; }
        public string? FechaCompra {get;set;}
        public string? FechaVencimiento {get;set;}
        public Vehiculo vehiculo {get;set;} // llave Foranea
        

    }
}