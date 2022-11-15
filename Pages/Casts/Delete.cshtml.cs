using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Pages.Casts
{
    public class DeleteModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;

        public DeleteModel(TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cast Cast { get; set; } = default!;




        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Cast == null)
            {
                return NotFound();
            }

            var cast = await _context.Cast.FirstOrDefaultAsync(m => m.ID == id);

            if (cast == null)
            {
                return NotFound();

            }
            else
            {

            }

            Cast = cast;
            ViewData["MovieID"] = new SelectList(_context.Movie, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Cast == null)
            {
                return NotFound();
            }
            var cast = await _context.Cast.FindAsync(id);

            if (cast != null)
            {
                Cast = cast;
                _context.Cast.Remove(Cast);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
