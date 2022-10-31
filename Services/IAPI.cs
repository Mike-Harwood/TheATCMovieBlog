
using static TheATCMovieBlog.DTO.MovieDTO;

namespace TheATCMovieBlog.Services
{
    public interface IAPI
    {
        Task<ApiMovie> MovieAPI();
    }
}