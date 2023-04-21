using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class ApiModel : PageModel
    {
        private readonly ILogger<ApiModel> _logger;

        public ApiModel(ILogger<ApiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}