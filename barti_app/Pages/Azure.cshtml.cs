using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class AzureModel : PageModel
    {
        private readonly ILogger<AzureModel> _logger;

        public AzureModel(ILogger<AzureModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}