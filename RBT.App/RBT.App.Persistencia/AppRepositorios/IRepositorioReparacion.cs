using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioReparacion
    {
        IEnumerable<Reparacion> ListarReparacionAll();
        Reparacion AgregarReparacion(Reparacion reparacion);
        Reparacion ActualizarReparacion(Reparacion reparacion);
        void EliminarReparacion(int idReparacion); 
        // El profe en el video deja el ID en letras minusculas
        Reparacion ObtenerReparacion(int idReparacion);    
    }
}