using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class PowershellModel : PageModel
    {
        private readonly ILogger<PowershellModel> _logger;

        public PowershellModel(ILogger<PowershellModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}