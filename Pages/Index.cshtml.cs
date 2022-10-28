using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheATCMovieBlog.Services;
using static TheATCMovieBlog.DTO.MovieDTO;

namespace TheATCMovieBlog.Pages
{



    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {



//          

        }
    }
}