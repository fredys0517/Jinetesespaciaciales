using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public class RepositorioUsuarioApp:IRepositorioUsuarioApp
    {
        
        
        private readonly AppContext _appContext; //Por que "app" en letras minusculas?

        public RepositorioUsuarioApp(AppContext appContext)
        {
            _appContext=appContext;
        }

        UsuarioApp IRepositorioUsuarioApp.AgregarUsuarioApp(UsuarioApp usuarioApp)
        {
            var usuarioAppAgregado= _appContext.UsuariosApp.Add(usuarioApp);
            _appContext.SaveChanges();
            return usuarioAppAgregado.Entity;
        }
        
        void IRepositorioUsuarioApp.EliminarUsuarioApp(int idUsuarioApp)
        {
            var usuarioAppEncontrado = _appContext.UsuariosApp.FirstOrDefault(m =>m.Id==idUsuarioApp);
            
            if (usuarioAppEncontrado==null)
                return;
            _appContext.UsuariosApp.Remove(usuarioAppEncontrado);
            _appContext.SaveChanges();
                
        }

        IEnumerable<UsuarioApp> IRepositorioUsuarioApp.ListarUsuarioAppAll()
        {
            return _appContext.UsuariosApp;
        }

        UsuarioApp IRepositorioUsuarioApp.ObtenerUsuarioApp(int idUsuarioApp)
        {
            return _appContext.UsuariosApp.FirstOrDefault(m =>m.Id==idUsuarioApp);

        }

        UsuarioApp IRepositorioUsuarioApp.ActualizarUsuarioApp(UsuarioApp usuarioApp)
        {// el simbolo "=>" quiere decir donde. La letra "m" hace referencia a la tabla usuariosapp.
            var usuarioAppEncontrado= _appContext.UsuariosApp.FirstOrDefault(m =>m.Id==usuarioApp.Id); // No estoy seguro de que sea "UsuarioApp.Id"

            if(usuarioAppEncontrado!=null)
            {
                usuarioAppEncontrado.Nombres=usuarioApp.Nombres;
                usuarioAppEncontrado.Apellidos=usuarioApp.Apellidos;
                usuarioAppEncontrado.Telefono=usuarioApp.Telefono;
                usuarioAppEncontrado.FechaNacimiento=usuarioApp.FechaNacimiento;
                _appContext.SaveChanges();
                
            }

            return usuarioAppEncontrado;

        }

    }
}