using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Vehiculo
    {
        
        public int Id { get; set; }
        public string Placa {get;set;}
        public string TipoVehiculo {get;set;}
        public string Marca {get;set;}
        public string Pasajero {get;set;}
        public string Cilindraje {get;set;}
        public string PaisOrigen {get;set;}
        public string CaracteristicasExtra {get;set;}

        //______________

        //public ICollection<Mantenimiento> Mantenimientos { get; set; }
        /* propiedad de navegacion */

        //______________

        //public int MecanicoId { get; set; } // Llave Foranea
        public Mecanico Mecanico {get;set;} // Propiedad de Navegacion

        //public int PropietarioId { get; set; } // Llave Foranea
        public Propietario Propietario {get;set;} // Propiedad de Navegacion

    }
}