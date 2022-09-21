using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.MantenimientoPage
{
    public class ListarMantenimiento : PageModel
    {
        private readonly ILogger<ListarMantenimiento> _logger;

        public ListarMantenimiento(ILogger<ListarMantenimiento> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}