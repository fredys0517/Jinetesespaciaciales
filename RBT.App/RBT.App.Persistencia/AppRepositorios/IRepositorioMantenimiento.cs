using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioMantenimiento
    {
        IEnumerable<Mantenimiento> ListarMantenimientoAll();
        Mantenimiento AgregarMantenimiento(Mantenimiento mantenimiento);
        Mantenimiento ActualizarMantenimiento(Mantenimiento mantenimiento);
        void EliminarMantenimiento(int idMantenimiento); 
        // El profe en el video deja el ID en letras minusculas
        Mantenimiento ObtenerMantenimiento(int idMantenimiento);    
    }
}