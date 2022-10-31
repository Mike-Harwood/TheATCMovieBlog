using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheATCMovieBlog.Services;
using static TheATCMovieBlog.DTO.MovieDTO;

namespace TheATCMovieBlog.Pages
{



    public class IndexModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly IAPI _api;
        public IndexModel(ILogger<IndexModel> logger, IAPI api, TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _api = api;
            _context = context;
        }

        public ApiMovie MovieAPI2 { get; set; } = new ApiMovie();



        public async Task<IActionResult> OnGet()
        {

            MovieAPI2 = await _api.MovieAPI();

            return Page();


        }




    }
}