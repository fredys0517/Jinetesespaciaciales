using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioJefeOperaciones
    {
        IEnumerable<JefeOperaciones> ListarJefeOperacionesAll();
        JefeOperacionesAgregarJefeOperaciones(JefeOperaciones jefeOperaciones);
        JefeOperaciones ActualizarJefeOperaciones(JefeOperaciones jefeOperaciones);
        void EliminarJefeOperaciones(int idJefeOperaciones); 
        // El profe en el video deja el ID en letras minusculas
        JefeOperaciones ObtenerJefeOperaciones(int idJefeOperaciones);    
    }
}