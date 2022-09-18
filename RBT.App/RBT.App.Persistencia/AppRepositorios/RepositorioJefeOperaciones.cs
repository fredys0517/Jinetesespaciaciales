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

        JefeOperaciones IRepositorioJefeOperaciones.AgregarJefeOperaciones(JefeOperaciones jefeoperaciones)
        {
            var jefeoperacionesAgregado= _appContext.JefesOperaciones.Add(jefeoperaciones);
            _appContext.SaveChanges();
            return jefeoperacionesAgregado.Entity;
        }
        
        void IRepositorioJefeOperaciones.EliminarJefeOperaciones(int idJefeOperaciones)
        {
            var jefeoperacionesEncontrado = _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==idJefeOperaciones);
            
            if (jefeoperacionesEncontrado==null)
                return;
            _appContext.JefesOperaciones.Remove(jefeoperacionesEncontrado);
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

        JefeOperaciones IRepositorioJefeOperaciones.ActualizarJefeOperaciones(JefeOperaciones jefeoperaciones)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla jefesoperaciones.
            var jefeoperacionesEncontrado= _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==jefeoperaciones.Id); // No estoy seguro de que sea "JefeOperaciones.Id"

            if(jefeoperacionesEncontrado!=null)
            {
                jefeoperacionesEncontrado.Nombres=jefeoperaciones.Nombres;
                jefeoperacionesEncontrado.Apellidos=jefeoperaciones.Apellidos;
                jefeoperacionesEncontrado.Telefono=jefeoperaciones.Telefono;
                jefeoperacionesEncontrado.FechaNacimiento=jefeoperaciones.FechaNacimiento;                
                _appContext.SaveChanges();
                
            }

            return jefeoperacionesEncontrado;

        }

    }
}