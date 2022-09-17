using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioMantenimiento:IRepositorioMantenimiento
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioMantenimiento(AppContext appContext)
        {
            _appContext=appContext;
        }

        Mantenimiento IRepositorioMantenimiento.AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            var mantenimientoAgregado= _appContext.Mantenimientoes.Add(mantenimiento);
            _appContext.SaveChanges();
            return mantenimientoAgregado.Entity;
        }
        
        void IRepositorioMantenimiento.EliminarMantenimiento(int idMantenimiento)
        {
            var mantenimientoEncontrado = _appContext.Mantenimientos.FirstOrDefault(m =>m.Id==idMantenimiento);
            
            if (mantenimientoEncontrado==null)
                return;
            _appContext.Mantenimientos.Remove(mantenimientoEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Mantenimiento> IRepositorioMantenimiento.ListarMantenimientoAll()
        {
            return _appContext.Mantenimientos;
        }

        Mantenimiento IRepositorioMantenimiento.ObtenerMantenimiento(int idMantenimiento)
        {
            return _appContext.Mantenimientos.FirstOrDefault(m =>m.Id==idMantenimiento);

        }

        Mantenimiento IRepositorioMantenimiento.ActualizarMantenimiento(Mantenimiento mantenimiento)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla mecanicos.
            var mantenimientoEncontrado= _appContext.Mantenimientos.FirstOrDefault(m =>m.Id==mantenimiento.Id); // No estoy seguro de que sea "Mecanico.Id"

            if(mantenimientoEncontrado!=null)
            {
                mantenimientoEncontrado.NivelAceite=mantenimiento.NivelAceite;
                mantenimientoEncontrado.NivelLiquidoFrenos=mantenimiento.NivelLiquidoFrenos;
                mantenimientoEncontrado.NivelRefrigerante=mantenimiento.NivelRefrigerante;
                mantenimientoEncontrado.NivelLiquidoDireccion=mantenimiento.NivelLiquidoDireccion;
                mantenimientoEncontrado.FechaMantenimiento=mantenimiento.FechaMantenimiento;  
                _appContext.SaveChanges();
                
            }

            return mantenimientoEncontrado;

        }

//julian es muy bravo
    
    }
}