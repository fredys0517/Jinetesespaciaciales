using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioSoat:IRepositorioSoat
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioSoat(AppContext appContext)
        {
            _appContext=appContext;
        }

        Soat IRepositorioSoat.AgregarSoat(Soat soat)
        {
            var soatAgregado= _appContext.Soats.Add(soat);
            _appContext.SaveChanges();
            return soatAgregado.Entity;
        }
        
        void IRepositorioSoat.EliminarSoat(int idSoat)
        {
            var soatEncontrado = _appContext.Soats.FirstOrDefault(m =>m.Id==idSoat);
            
            if (soatEncontrado==null)
                return;
            _appContext.Soats.Remove(soatEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<Soat> IRepositorioSoat.ListarSoatAll()
        {
            return _appContext.Soats;
        }

        Soat IRepositorioSoat.ObtenerSoat(int idSoat)
        {
            return _appContext.Soats.FirstOrDefault(m =>m.Id==idSoat);

        }

        Soat IRepositorioSoat.ActualizarSoat(Soat soat)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla soats.
            var soatEncontrado= _appContext.Soats.FirstOrDefault(m =>m.Id==soat.Id); // No estoy seguro de que sea "Soat.Id"

            if(soatEncontrado!=null)
            {
                soatEncontrado.FechaCompra=soat.FechaCompra;
                soatEncontrado.FechaVencimiento=soat.FechaVencimiento;

                //Esta es una llave foranea, ¿se puede modificar?
                //soatEncontrado.vehiculo=soat.vehiculo;

                _appContext.SaveChanges();
                
            }

            return soatEncontrado;

        }

    }
}