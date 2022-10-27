namespace TheATCMovieBlog.Models
{
    public class Cast
    {

        public Guid ID { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ScreenName { get; set; }

        public Guid MovieID { get; set; }

        public Movie? Movie { get; set; }



    }
}
