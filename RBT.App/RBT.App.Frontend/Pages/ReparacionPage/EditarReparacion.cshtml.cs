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
    public class EditarReparacion : PageModel
    {
        
        
        private readonly IRepositorioReparacion repositorioReparacion = new RepositorioReparacion(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Reparacion EditRep { get; set; }

        public IActionResult OnGet(int ReparacionId)
        {
            
            EditRep=repositorioReparacion.ObtenerReparacion(ReparacionId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioReparacion.ActualizarReparacion(EditRep);
            return RedirectToPage("./ListarReparacion");
        }
    }
}