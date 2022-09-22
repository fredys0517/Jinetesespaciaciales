using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioReparacion:IRepositorioReparacion
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioReparacion(AppContext appContext)
        {
            _appContext=appContext;
        }

        Reparacion IRepositorioReparacion.AgregarReparacion(Reparacion reparacion)
        {
            var reparacionAgregado= _appContext.Reparaciones.Add(reparacion);
            _appContext.SaveChanges();
            return reparacionAgregado.Entity;
        }
        
        void IRepositorioReparacion.EliminarReparacion(int idReparacion)
        {
            var reparacionEncontrado = _appContext.Reparaciones.FirstOrDefault(m =>m.Id==idReparacion);
            
            if (reparacionEncontrado==null)
                return;
            _appContext.Reparaciones.Remove(reparacionEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Reparacion> IRepositorioReparacion.ListarReparacionAll()
        {
            return _appContext.Reparaciones;
        }

        Reparacion IRepositorioReparacion.ObtenerReparacion(int idReparacion)
        {
            return _appContext.Reparaciones.FirstOrDefault(m =>m.Id==idReparacion);

        }

        Reparacion IRepositorioReparacion.ActualizarReparacion(Reparacion reparacion)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla reparaciones.
            var reparacionEncontrado= _appContext.Reparaciones.FirstOrDefault(m =>m.Id==reparacion.Id); // No estoy seguro de que sea "Reparacion.Id"

            //if(reparacionEncontrado!=null)
            {
                reparacionEncontrado.FechaReparacion=reparacion.FechaReparacion;
                reparacionEncontrado.RepuestosCambiados=reparacion.RepuestosCambiados;
                
                //Esta es una llave foranea, ¿se puede modificar?
                //reparacionEncontrado.mantenimiento=reparacion.mantenimiento;
                
                _appContext.SaveChanges();
                
            }

            return reparacionEncontrado;

        }

    }
}