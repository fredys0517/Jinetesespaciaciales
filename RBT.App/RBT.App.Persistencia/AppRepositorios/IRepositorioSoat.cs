using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioSoat
    {
        IEnumerable<Soat> ListarSoatAll();
        Soat AgregarSoat(Soat soat);
        Soat ActualizarSoat(Soat soat);
        void EliminarSoat(int idSoat); 
        // El profe en el video deja el ID en letras minusculas
        Soat ObtenerSoat(int idSoat);    
    }
}