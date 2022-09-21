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

namespace RBT.App.Frontend.Pages.SoatPage
{
    public class EditarSoat : PageModel
    {
        
        
        private readonly IRepositorioSoat repositorioSoat = new RepositorioSoat(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Soat EditSoat { get; set; }

        public IActionResult OnGet(int SoatId)
        {
            
            EditSoat=repositorioSoat.ObtenerSoat(SoatId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioSoat.ActualizarSoat(EditSoat);
            return RedirectToPage("./ListarSoat");
        }
    }
}