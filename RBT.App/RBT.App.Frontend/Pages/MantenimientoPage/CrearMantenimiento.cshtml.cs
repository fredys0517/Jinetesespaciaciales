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
    public class CrearMantenimiento : PageModel
    {
        private readonly IRepositorioMantenimiento repositorioMantenimiento = new RepositorioMantenimiento(
            new Persistencia.AppContext()
        );
        [BindProperty]
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public Mantenimiento CreateMant { get; set; }=new();

        public void OnGet() { }
        public IActionResult OnPost()
        {

            repositorioMantenimiento.AgregarMantenimiento(CreateMant);
            return RedirectToPage("./ListarMantenimiento");
        } 
    }
}