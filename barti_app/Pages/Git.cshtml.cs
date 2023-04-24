using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class GitModel : PageModel
    {
        private readonly ILogger<GitModel> _logger;

        public GitModel(ILogger<GitModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}