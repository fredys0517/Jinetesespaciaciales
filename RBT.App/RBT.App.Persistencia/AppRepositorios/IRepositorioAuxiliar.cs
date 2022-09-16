using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> ListarMecanicoAll();
        AuxiliarAgregarAuxiliar(Auxiliar auxiliar);
        Auxiliar ActualizarAuxiliar(Auxiliar auxiliar);
        void EliminarAuxiliar(int idAuxiliar); 
        // El profe en el video deja el ID en letras minusculas
        Auxiliar ObtenerMecanico(int idAuxiliar);    

        //Auxiliar AgregarAuxiliar(Mecanico MecAgregar);

        //Mecanico ActualizarMecanico(Mecanico MecActualizar);
    }
}