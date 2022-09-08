using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RBT.App.Dominio
{
    public class UsuarioApp:Persona
    {
        
        public int IdUsuarioApp { get; set; }
        public Persona FkIdPersona {get;set;}
       

    }
}