﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Pages.Casts
{
    public class DetailsModel : PageModel
    {
        private readonly TheATCMovieBlog.Data.ApplicationDbContext _context;

        public DetailsModel(TheATCMovieBlog.Data.ApplicationDbContext context)
        {
            _context = context;
        }



        public Cast Cast { get; set; }

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
                Cast = cast;
            }
            return Page();




        }
    }
}

