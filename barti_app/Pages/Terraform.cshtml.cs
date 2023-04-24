﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class TerraformModel : PageModel
    {
        private readonly ILogger<TerraformModel> _logger;

        public TerraformModel(ILogger<TerraformModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}