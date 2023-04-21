using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class PostmanModel : PageModel
    {
        private readonly ILogger<PostmanModel> _logger;

        public PostmanModel(ILogger<PostmanModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}