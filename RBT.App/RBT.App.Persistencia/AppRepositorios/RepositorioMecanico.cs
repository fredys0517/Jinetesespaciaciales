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
            var mecanicoEncontrado = _appContext.Mecanicos.FirstOrDefault(m =>m.Id==idMecanico);
            
            if (mecanicoEncontrado==null)
                return;
            _appContext.Mecanicos.Remove(mecanicoEncontrado);
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
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla mecanicos.
            var mecanicoEncontrado= _appContext.Mecanicos.FirstOrDefault(m =>m.Id==mecanico.Id); // No estoy seguro de que sea "Mecanico.Id"

            if(mecanicoEncontrado!=null)
            {
                mecanicoEncontrado.Nombres=mecanico.Nombres;
                mecanicoEncontrado.Apellidos=mecanico.Apellidos;
                mecanicoEncontrado.Telefono=mecanico.Telefono;
                mecanicoEncontrado.FechaNacimiento=mecanico.FechaNacimiento;

                mecanicoEncontrado.Direccion=mecanico.Direccion;
                mecanicoEncontrado.NivelEstudios=mecanico.NivelEstudios;
                
                _appContext.SaveChanges();
                
            }

            return mecanicoEncontrado;

        }

    }
}