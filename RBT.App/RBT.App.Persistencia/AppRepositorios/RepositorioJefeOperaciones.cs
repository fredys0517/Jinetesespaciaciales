using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioJefeOperaciones:IRepositorioJefeOperaciones
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioJefeOperaciones(AppContext appContext)
        {
            _appContext=appContext;
        }

        JefeOperaciones IRepositorioJefeOperaciones.AgregarJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var jefeOperacionesAgregado= _appContext.JefesOperaciones.Add(jefeOperaciones);
            _appContext.SaveChanges();
            return jefeOperacionesAgregado.Entity;
        }
        
        void IRepositorioJefeOperaciones.EliminarJefeOperaciones(int idJefeOperaciones)
        {
            var jefeOperacionesEncontrado = _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==idJefeOperaciones);
            
            if (jefeOperacionesEncontrado==null)
                return;
            _appContext.JefesOperaciones.Remove(jefeOperacionesEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<JefeOperaciones> IRepositorioJefeOperaciones.ListarJefeOperacionesAll()
        {
            return _appContext.JefesOperaciones;
        }

        JefeOperaciones IRepositorioJefeOperaciones.ObtenerJefeOperaciones(int idJefeOperaciones)
        {
            return _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==idJefeOperaciones);

        }

        JefeOperaciones IRepositorioJefeOperaciones.ActualizarJefeOperaciones(JefeOperaciones jefeOperaciones)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla mecanicos.
            var jefeOperacionesEncontrado= _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==jefeOperaciones.Id); // No estoy seguro de que sea "JefeOperaciones.Id"

            if(jefeOperacionesEncontrado!=null)
            {
                jefeOperacionesEncontrado.Nombres=jefeOperaciones.Nombres;
                jefeOperacionesEncontrado.Apellidos=jefeOperaciones.Apellidos;
                jefeOperacionesEncontrado.Telefono=jefeOperaciones.Telefono;
                jefeOperacionesEncontrado.FechaNacimiento=jefeOperaciones.FechaNacimiento;
                _appContext.SaveChanges();
                
            }

            return jefeOperacionesEncontrado;
        }
    
    }
}    
