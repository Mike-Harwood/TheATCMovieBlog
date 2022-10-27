using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Data;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;

        public IndexModel(TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
