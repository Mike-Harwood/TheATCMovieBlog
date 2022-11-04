using System.ComponentModel.DataAnnotations;

namespace TheATCMovieBlog.Models
{
    public class Cast
    {

        public Guid ID { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Screen Name")]
        public string? ScreenName { get; set; }
        [Display(Name = "Movie Name")]
        public Guid MovieID { get; set; }

        public Movie? Movie { get; set; }



    }
}
