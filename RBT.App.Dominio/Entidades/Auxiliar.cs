using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio.Entidades
{
    public class Auxiliar:Persona
    {
        public int IdAuxiliar {get;set;}
        public Persona FkIdPersona {get;set;}
    }
}