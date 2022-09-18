using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.ReparacionPage
{
    public class Reparacion : PageModel
    {
        private readonly ILogger<Reparacion> _logger;

        public Reparacion(ILogger<Reparacion> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}