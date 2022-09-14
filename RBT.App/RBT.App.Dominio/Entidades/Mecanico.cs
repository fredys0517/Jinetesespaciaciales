using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Mecanico
    {
        //[key] // buscar el codigopara poder darle nombre a la llave
        public int Id {get;set;}
        public string? Nombres {get;set;}
        public string? Apellidos {get;set;}
        public string? Telefono {get;set;}
        public string? FechaNacimiento {get;set;}
        
        public string? Direccion {get;set;}
        public string? NivelEstudios {get;set;}

        // __________________________________________________
        //public ICollection<Vehiculo> Vehiculos { get; set; }// Uno a varios con vehiculo
        

    }
}