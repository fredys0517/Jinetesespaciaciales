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
            var jefeOperacionesAgregado= _appContext.JefeOperaciones.Add(jefeOperaciones);
            _appContext.SaveChanges();
            return jefeOperacionesAgregado.Entity;
        }
        
        void IRepositorioJefeOperaciones.EliminarJefeOperaciones(int idJefeOperaciones)
        {
            var jefeOperacionesEncontrado = _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==idJefeOperaciones);
            
            if (jefeOperacionesEncontrado==null)
                return;
            _appContext.JefesOperaciones.Remove(JefeOperacionesEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<jefeOperaciones> IRepositorioJefeOperaciones.ListarJefeOperacionesAll()
        {
            return _appContext.JefesOperaciones;
        }

        jefeOperaciones IRepositorioJefeOperaciones.ObtenerJefeOperaciones(int idJefeOperaciones)(int idAuxiliar)
        {
            return _appContext.JefesOperacioness.FirstOrDefault(m =>m.Id==idJefeOperaciones);

        }

        jefeOperaciones IRepositorioJefeOperaciones.ActualizarJefeOperaciones(JefeOperaciones jefeOperaciones)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla mecanicos.
            var jefeOperacionesEncontrado= _appContext.JefesOperaciones.FirstOrDefault(m =>m.Id==jefeOperaciones.Id); // No estoy seguro de que sea "Mecanico.Id"

            if(JefeOperacionesEncontrado!=null)
            {
                JefeOperacionesEncontrado.Nombres=jefeOperaciones.Nombres;
                JefeOperacionesEncontradoo.Apellidos=jefeOperaciones.Apellidos;
                JefeOperacionesEncontrado.Telefono=jefeOperaciones.Telefono;
                JefeOperacionesEncontrado.FechaNacimiento=jefeOperaciones.FechaNacimiento;

            
                
                _appContext.SaveChanges();
                
            }

            return jefeOperacionesEncontrado;

        }


        /*
          private readonly AppContext MecContext;
        public RepositorioMecanico (AppContext Mec)
        {
            MecContext=Mec;
        }
        IEnumerable<Mecanico> ListarMecanicoAll()
        {
            return MecContext.Mecanico;
        }

        Mecanico SekeccionarMecanico(int IdMecanico)
        {

            return MecContext.Mecanico.FirstOrDefault
            (m => m.IdMecanico==IdMecanico);
        } */
    }
}