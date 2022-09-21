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

namespace RBT.App.Frontend.Pages.MantenimientoPage
{
    public class EditarMantenimiento : PageModel
    {
        
        private readonly IRepositorioMantenimiento repositorioMantenimiento = new RepositorioMantenimiento(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Mantenimiento EditMant { get; set; }

        public IActionResult OnGet(int MantenimientoId)
        {
            
            EditMant=repositorioMantenimiento.ObtenerMantenimiento(MantenimientoId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioMantenimiento.ActualizarMantenimiento(EditMant);
            return RedirectToPage("./ListarMantenimiento");
        }

    }
}