using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class AzureDevOpsModel : PageModel
    {
        private readonly ILogger<AzureDevOpsModel> _logger;

        public AzureDevOpsModel(ILogger<AzureDevOpsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}