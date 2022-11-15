using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheATCMovieBlog.MovieDTO;
using TheATCMovieBlog.Services;

namespace TheATCMovieBlog.Pages
{

    [BindProperties]

    public class IndexModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly IAPI _iapi;


        public string GetMovieImagePath(string partialPath)
        { return "https://image.tmdb.org/t/p/w300/" + partialPath; }

        private string[] movieIDs = new string[] { "557", "2034", "73586", "113988" };

        public Root[] Roots = new Root[4];
        public IndexModel(ILogger<IndexModel> logger, IAPI iapi, TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _iapi = iapi;
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





        //public ApiMovie MovieAPI2 { get; set; } = new ApiMovie();



        public void OnGet()
        {

            //MovieAPI2 = await _iapi.MovieAPI();

            //return Page();
            for (int i = 0; i < movieIDs.Length; i++)
            {
                Roots[i] = _iapi.MovieAPI(movieIDs[i]).Result;
            }

        }




    }
}