using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class AnsibleModel : PageModel
    {
        private readonly ILogger<AnsibleModel> _logger;

        public AnsibleModel(ILogger<AnsibleModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}