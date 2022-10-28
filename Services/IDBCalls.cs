using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Services;

public interface IDBCalls
{
    IEnumerable<Cast> CastQuery(Guid ID);

}