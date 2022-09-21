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
    public class ListarSoat : PageModel
    {
        
       private readonly IRepositorioSoat repositorioSoat = new RepositorioSoat(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Soat> ListaSoat { get; set; }

        public void OnGet()
        {
            ListaSoat = repositorioSoat.ListarSoatAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioSoat.EliminarSoat(numeroId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}