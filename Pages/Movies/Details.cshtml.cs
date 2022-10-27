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
    public class DetailsModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;

        public DetailsModel(TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Movie == null)
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
            return Page();
        }
    }
}
