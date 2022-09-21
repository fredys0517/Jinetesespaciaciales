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


namespace RBT.App.Frontend.Pages.ReparacionPage
{
    public class CrearReparacion : PageModel
    {
        private readonly IRepositorioReparacion repositorioReparacion = new RepositorioReparacion(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Reparacion CreateRep { get; set; }

        public void OnGet() { }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();

            repositorioReparacion.AgregarReparacion(CreateRep);
            return RedirectToPage("./ListarReparacion");
        }
    }
}