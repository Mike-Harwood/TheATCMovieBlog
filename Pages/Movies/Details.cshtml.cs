using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Models;
using TheATCMovieBlog.Services;
using Movie = TheATCMovieBlog.Models.Movie;


namespace TheATCMovieBlog.Pages.Movies
{
    public class DetailsModel : PageModel

    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;



        private readonly IDBCalls _calls;
        //IWebHostEnvironment

        private readonly IWebHostEnvironment _webHostEnvironment;
        public DetailsModel(TheATCMovieBlog.Data.ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IDBCalls calls)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _calls = calls;
        
        }


        public IEnumerable<Cast> CastNames { get; set; }
        //public IEnumerable<API> MovieAPI { get; set; }


        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (_context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            CastNames = _calls.CastQuery(id);

            return Page();
        }
    }
}
