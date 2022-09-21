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

namespace RBT.App.Frontend.Pages.PropietarioPage
{
    public class EditarPropietario : PageModel
    {
        
        private readonly IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Propietario EditProp { get; set; }

        public IActionResult OnGet(int PropietarioId)
        {
            
            EditProp=repositorioPropietario.ObtenerPropietario(PropietarioId);
            return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            return Page();
            repositorioPropietario.ActualizarPropietario(EditProp);
            return RedirectToPage("./ListarPropietario");
        }

    }
}