using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TheATCMovieBlog.Models.Movie> Movie { get; set; }
        public DbSet<TheATCMovieBlog.Models.Cast> Cast { get; set; }
    }
}