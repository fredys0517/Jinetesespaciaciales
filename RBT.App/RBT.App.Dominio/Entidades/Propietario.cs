using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Propietario:Persona
    {
        
        public int PropietarioId { get; set; }
        //public Persona FkPersonaId {get;set;}
        public string CiudadResidencia {get;set;}
        public string Correo {get;set;}

        // __________________________________________________
        public ICollection<Vehiculo> Vehiculos { get; set; } //Uno a varios hacia vehiculo
       

    }
}