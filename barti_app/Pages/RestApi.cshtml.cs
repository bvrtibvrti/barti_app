using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class RestApiModel : PageModel
    {
        private readonly ILogger<RestApiModel> _logger;

        public RestApiModel(ILogger<RestApiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}