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
    public class CrearUsuario : PageModel
    {
        
        private readonly IRepositorioUsuarioApp repositorioUsuario = new RepositorioUsuarioApp(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public UsuarioApp CreateUsu { get; set; }

        public void OnGet() { }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();

            repositorioUsuario.AgregarUsuarioApp(CreateUsu);
            return RedirectToPage("./ListarUsuario");
        }
    }
}