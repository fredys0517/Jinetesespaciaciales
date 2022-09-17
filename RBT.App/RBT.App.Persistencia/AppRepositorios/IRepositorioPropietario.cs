using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> ListarPropietarioAll();
        Propietario AgregarPropietario(Propietario propietario);
        Propietario ActualizarPropietario(Propietario propietario);
        void EliminarPropietario(int idPropietario); 
        // El profe en el video deja el ID en letras minusculas
        Propietario ObtenerPropietario(int idPropietario);    
    }
}