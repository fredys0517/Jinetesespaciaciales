using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class Mecanico:Persona
    {
        public int MecanicoId {get;set;}
        //public Persona FkIdPersona { get; set; }
        public string Direccion {get;set;}
        public string NivelEstudios {get;set;}

        // __________________________________________________
        public ICollection<Vehiculo> Vehiculos { get; set; }// Uno a varios con vehiculo
        

    }
}