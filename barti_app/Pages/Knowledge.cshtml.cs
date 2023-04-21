using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BartiWebApp.Pages
{
    public class KnowledgeModel : PageModel
    {
        private readonly ILogger<KnowledgeModel> _logger;

        public KnowledgeModel(ILogger<KnowledgeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}