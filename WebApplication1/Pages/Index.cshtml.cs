using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.src.services.interfaces;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ITodo _todo;
        public IndexModel(ILogger<IndexModel> logger, ITodo itodo)
        {
            _logger = logger;
            _todo = itodo;
        }

        public void OnGet()
        {

        }
    }
}