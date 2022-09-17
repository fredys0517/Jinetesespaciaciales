using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext=appContext;
        }

        Propietario IRepositorioPropietario.AgregarPropietario(Propietario propietario)
        {
            var propietarioAgregado= _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAgregado.Entity;
        }
        
        void IRepositorioPropietario.EliminarPropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(m =>m.Id==idPropietario);
            
            if (propietarioEncontrado==null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Propietario> IRepositorioPropietario.ListarPropietarioAll()
        {
            return _appContext.Propietarios;
        }

        Propietario IRepositorioPropietario.ObtenerPropietario(int idPropietario)
        {
            return _appContext.Propietarios.FirstOrDefault(m =>m.Id==idPropietario);

        }

        Propietario IRepositorioPropietario.ActualizarPropietario(Propietario propietario)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla propietarios.
            var propietarioEncontrado= _appContext.Propietarios.FirstOrDefault(m =>m.Id==propietario.Id); // No estoy seguro de que sea "Propietario.Id"

            if(propietarioEncontrado!=null)
            {
                propietarioEncontrado.Nombres=propietario.Nombres;
                propietarioEncontrado.Apellidos=propietario.Apellidos;
                propietarioEncontrado.Telefono=propietario.Telefono;
                propietarioEncontrado.FechaNacimiento=propietario.FechaNacimiento;

                propietarioEncontrado.CiudadResidencia=propietario.CiudadResidencia;
                propietarioEncontrado.Correo=propietario.Correo;
                
                _appContext.SaveChanges();
                
            }

            return propietarioEncontrado;

        }

    }
}