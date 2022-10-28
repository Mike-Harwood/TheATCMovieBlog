using TheATCMovieBlog.DTO;

namespace TheATCMovieBlog.Services
{
    public interface IAPI
    {
        Task<MovieDTO.Root> MovieAPI();
    }
}