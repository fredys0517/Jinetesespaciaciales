using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Propietario
    {
        public int Id {get;set;}
        public string? Nombres {get;set;}
        public string? Apellidos {get;set;}
        public string? Telefono {get;set;}
        public string? FechaNacimiento {get;set;}
        
        public string CiudadResidencia {get;set;}
        public string Correo {get;set;}

        // __________________________________________________
        //public ICollection<Vehiculo> Vehiculos { get; set; } //Uno a varios hacia vehiculo
       

    }
}