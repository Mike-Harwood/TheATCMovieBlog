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
        //public IReadOnlyList<MovieInfo> Results { get; set; }
        //public Models.Movie Movie { get; set; }

        //public async Task OnGetAsync()
        //{
        //    //get the movie title https://github.com/nCubed/TheMovieDbWrapper https://github.com/nCubed/TheMovieDbWrapper/blob/master/DM.MovieApi.IntegrationTests/DM.MovieApi.IntegrationTests.cs

        //    var movieApi = MovieDbFactory.Create<IApiMovieRequest>().Value; 

        //    ApiSearchResponse<MovieInfo> response = await movieApi.GetTopRatedAsync();

        //    Results = response.Results;


        //}





        public ApiMovie MovieAPI2 { get; set; } = new ApiMovie();



        public async Task<IActionResult> OnGet()
        {

            MovieAPI2 = await _api.MovieAPI();

            return Page();


        }




    }
}