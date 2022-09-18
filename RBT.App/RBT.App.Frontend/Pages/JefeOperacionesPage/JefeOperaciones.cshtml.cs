using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RBT.App.Frontend.Pages.JefeOperacionesPage
{
    public class JefeOperaciones : PageModel
    {
        private readonly ILogger<JefeOperaciones> _logger;

        public JefeOperaciones(ILogger<JefeOperaciones> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}