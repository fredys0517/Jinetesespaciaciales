using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class JefeOperaciones:Persona
    {
        
        public int IdJefeOperaciones { get; set; }
        public Persona FkIdPersona {get;set;}
      

    }
}