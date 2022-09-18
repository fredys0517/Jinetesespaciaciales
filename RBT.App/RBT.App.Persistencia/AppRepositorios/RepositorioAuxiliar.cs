using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioAuxiliar:IRepositorioAuxiliar
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioAuxiliar(AppContext appContext)
        {
            _appContext=appContext;
        }

        Auxiliar IRepositorioAuxiliar.AgregarAuxiliar(Auxiliar auxiliar)
        {
<<<<<<< HEAD
            var mantenimientoAgregado= _appContext.Mantenimientos.Add(mantenimiento);
=======
            var auxiliarAgregado= _appContext.Auxiliares.Add(auxiliar);
>>>>>>> Monica
            _appContext.SaveChanges();
            return auxiliarAgregado.Entity;
        }
        
        void IRepositorioAuxiliar.EliminarAuxiliar(int idAuxiliar)
        {
            var auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(m =>m.Id==idAuxiliar);
            
            if (auxiliarEncontrado==null)
                return;
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Auxiliar> IRepositorioAuxiliar.ListarAuxiliarAll()
        {
            return _appContext.Auxiliares;
        }

        Auxiliar IRepositorioAuxiliar.ObtenerAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliares.FirstOrDefault(m =>m.Id==idAuxiliar);

        }

        Auxiliar IRepositorioAuxiliar.ActualizarAuxiliar(Auxiliar auxiliar)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla auxiliares.
            var auxiliarEncontrado= _appContext.Auxiliares.FirstOrDefault(m =>m.Id==auxiliar.Id); // No estoy seguro de que sea "Auxiliar.Id"

            if(auxiliarEncontrado!=null)
            {
                auxiliarEncontrado.Nombres=auxiliar.Nombres;
                auxiliarEncontrado.Apellidos=auxiliar.Apellidos;
                auxiliarEncontrado.Telefono=auxiliar.Telefono;
                auxiliarEncontrado.FechaNacimiento=auxiliar.FechaNacimiento;                
                _appContext.SaveChanges();
                
            }

            return auxiliarEncontrado;

        }

    }
}