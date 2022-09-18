using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> ListarVehiculoAll();
        Vehiculo AgregarVehiculo(Vehiculo vehiculo);
        Vehiculo ActualizarVehiculo(Vehiculo vehiculo);
        void EliminarVehiculo(int idVehiculo); 
        // El profe en el video deja el ID en letras minusculas
        Vehiculo ObtenerVehiculo(int idVehiculo);    
    }
}