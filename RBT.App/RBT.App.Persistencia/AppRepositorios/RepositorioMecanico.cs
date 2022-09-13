using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioMecanico:IRepositorioMecanico
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioMecanico(AppContext appContext)
        {
            _appContext=appContext;
        }

        Mecanico IRepositorioMecanico.AgregarMecanico(Mecanico mecanico)
        {
            var mecanicoAgregado= _appContext.Mecanicos.Add(mecanico);
            _appContext.SaveChanges();
            return mecanicoAgregado.Entity;
        }
        
        void IRepositorioMecanico.EliminarMecanico(int idMecanico)
        {
            var mecanicoEcontrado= _appContext.Mecanicos.FirstOrDefault(m =>m.Id==idMecanico);
            
            if (mecanicoEncontrado=null)
                return;
            _appContext.Mecanicos.Remove(mecanicoEcontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Mecanico> IRepositorioMecanico.ListarMecanicoAll()
        {
            return _appContext.Mecanicos;
        }

        Mecanico IRepositorioMecanico.ObtenerMecanico(int idMecanico)
        {
            return _appContext.Mecanicos.FirstOrDefault(m =>m.Id==idMecanico);

        }

        Mecanico IRepositorioMecanico.ActualizarMecanico(Mecanico mecanico)
        {
            var mecanicoEcontrado= _appContext.Mecanicos.FirstOrDefault(m =>m.Id==Mecanico.Id); // No estoy seguro de que sea "Mecanico.Id"

            if(mecanicoEcontrado!=null)
            {
                mecanicoEcontrado.Nombres=mecanico.Nombres;
                mecanicoEcontrado.Apellidos=mecanico.Apellidos;
                mecanicoEcontrado.Telefono=mecanico.Telefono;
                mecanicoEcontrado.FechaNacimiento=mecanico.FechaNacimiento;

                mecanicoEcontrado.Direccion=mecanico.Direccion;
                mecanicoEcontrado.NivelEstudios=mecanico.NivelEstudios;
                
                _appContext.SaveChanges();
                
            }

            return mecanicoEcontrado;

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