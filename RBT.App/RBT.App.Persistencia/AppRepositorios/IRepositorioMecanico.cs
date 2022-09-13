using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioMecanico
    {
        IEnumerable<Mecanico> ListarMecanicoAll();
        Mecanico AgregarMecanico(Mecanico mecanico);
        Mecanico ActualizarMecanico(Mecanico mecanico);
        void EliminarMecanico(int idMecanico); 
        // El profe en el video deja el ID en letras minusculas
        Mecanico ObtenerMecanico(int idMecanico);    

        //Mecanico AgregarMecanico(Mecanico MecAgregar);

        //Mecanico ActualizarMecanico(Mecanico MecActualizar);
    }
}