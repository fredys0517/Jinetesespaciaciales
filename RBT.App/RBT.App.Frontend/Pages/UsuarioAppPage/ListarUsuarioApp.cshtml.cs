using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
//---------------------------------------
using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Frontend.Pages.UsuarioAppPage
{
    public class ListarUsuarioApp : PageModel
    {
        private readonly IRepositorioUsuarioApp repositorioUsuarioApp = new RepositorioUsuarioApp(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<UsuarioApp> ListaUsuariosApp { get; set; }

        public void OnGet()
        {
            ListaUsuariosApp = repositorioUsuarioApp.ListarUsuarioAppAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioUsuarioApp.EliminarUsuarioApp(numeroId);
            return RedirectToAction("Get");
        }
    }
}