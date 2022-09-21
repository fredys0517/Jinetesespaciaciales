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

namespace RBT.App.Frontend.Pages.MecanicoPage
{
    public class EditarMecanico : PageModel
    {
        
        private readonly IRepositorioMecanico repositorioMecanico = new RepositorioMecanico(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Mecanico EditMec { get; set; }

        public IActionResult OnGet(int MecanicoId)
        {
            
            EditMec=repositorioMecanico.ObtenerMecanico(MecanicoId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioMecanico.ActualizarMecanico(EditMec);
            return RedirectToPage("./ListarMecanico");
        }
    }
}