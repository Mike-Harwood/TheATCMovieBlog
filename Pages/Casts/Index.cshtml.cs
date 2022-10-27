using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Pages.Casts
{
    public class IndexModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;

        public IndexModel(TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cast> Cast { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cast != null)
            {
                Cast = await _context.Cast
                .Include(c => c.Movie).ToListAsync();
            }
        }
    }
}
