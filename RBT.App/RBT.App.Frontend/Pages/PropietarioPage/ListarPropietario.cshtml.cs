using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using RBT.App.Dominio;
using RBT.App.Persistencia;

namespace RBT.App.Frontend.Pages.PropietarioPage
{
    public class ListarPropietario : PageModel
    {
        
        private readonly IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        //CREAR UNA LISTA DONDE SE VA A GUARDAR LO QUE VENGA DEL REPOSITORIO
        public IEnumerable<Propietario> ListaPropietario { get; set; }

        public void OnGet()
        {
            ListaPropietario = repositorioPropietario.ListarPropietarioAll();
        }
        
        // Esta es la accion del boton eliminar--------------
        public IActionResult OnPost(int numeroId)
        {
            repositorioPropietario.EliminarPropietario(numeroId);
            return RedirectToAction("Get");
        }
        //----------------------------------------------------
    }
}