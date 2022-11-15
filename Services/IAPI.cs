using TheATCMovieBlog.MovieDTO;

namespace TheATCMovieBlog.Services
{
    public interface IAPI
    {
        Task<Root> MovieAPI(string Id);
    }
}