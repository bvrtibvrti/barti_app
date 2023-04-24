using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class PowerBiModel : PageModel
    {
        private readonly ILogger<PowerBiModel> _logger;

        public PowerBiModel(ILogger<PowerBiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}