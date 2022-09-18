using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBT.App.Dominio;

namespace RBT.App.Persistencia
{
    public interface IRepositorioUsuarioApp
    {
        IEnumerable<UsuarioApp> ListarUsuarioAppAll();
        UsuarioApp AgregarUsuarioApp(UsuarioApp usuarioApp);
        UsuarioApp ActualizarUsuarioApp(UsuarioApp usuarioApp);
        void EliminarUsuarioApp(int idUsuarioApp); 
        // El profe en el video deja el ID en letras minusculas
        UsuarioApp ObtenerUsuarioApp(int idUsuarioApp);    
    }
}