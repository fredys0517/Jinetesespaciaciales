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

namespace RBT.App.Frontend.Pages.AuxiliarPage
{
    public class EditarAuxiliar : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar = new RepositorioAuxiliar(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Auxiliar EditAux { get; set; }

        public IActionResult OnGet(int AuxiliarId)
        {
            
            EditAux=repositorioAuxiliar.ObtenerAuxiliar(AuxiliarId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioAuxiliar.ActualizarAuxiliar(EditAux);
            return RedirectToPage("./ListarAuxiliar");
        }

    }
}