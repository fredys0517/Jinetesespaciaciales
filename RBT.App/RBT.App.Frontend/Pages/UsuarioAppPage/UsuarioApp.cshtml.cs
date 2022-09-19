using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.UsuarioAppPage
{
    public class UsuarioApp : PageModel
    {
        private readonly ILogger<UsuarioApp> _logger;

        public UsuarioApp(ILogger<UsuarioApp> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}