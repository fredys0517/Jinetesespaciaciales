using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext=appContext;
        }

        Vehiculo IRepositorioVehiculo.AgregarVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAgregado= _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAgregado.Entity;
        }
        
        void IRepositorioVehiculo.EliminarVehiculo(int idVehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(m =>m.Id==idVehiculo);
            
            if (vehiculoEncontrado==null)
                return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Vehiculo> IRepositorioVehiculo.ListarVehiculoAll()
        {
            return _appContext.Vehiculos;
        }

        Vehiculo IRepositorioVehiculo.ObtenerVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(m =>m.Id==idVehiculo);

        }

        Vehiculo IRepositorioVehiculo.ActualizarVehiculo(Vehiculo vehiculo)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla vehiculos.
            var vehiculoEncontrado= _appContext.Vehiculos.FirstOrDefault(m =>m.Id==vehiculo.Id); // No estoy seguro de que sea "Vehiculo.Id"

            if(vehiculoEncontrado!=null)
            {
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.TipoVehiculo=vehiculo.TipoVehiculo;
                vehiculoEncontrado.Marca=vehiculo.Marca;
                vehiculoEncontrado.Pasajero=vehiculo.Pasajero;
                vehiculoEncontrado.Cilindraje=vehiculo.Cilindraje;
                vehiculoEncontrado.PaisOrigen=vehiculo.PaisOrigen;
                vehiculoEncontrado.CaracteristicasExtra=vehiculo.CaracteristicasExtra;
                vehiculoEncontrado.mecanico=vehiculo.mecanico;
                vehiculoEncontrado.propietario=vehiculo.propietario;

                
                _appContext.SaveChanges();
                
            }

            return vehiculoEncontrado;

        }

    }
}