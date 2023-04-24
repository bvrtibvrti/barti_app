using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class KubernetesModel : PageModel
    {
        private readonly ILogger<KubernetesModel> _logger;

        public KubernetesModel(ILogger<KubernetesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}