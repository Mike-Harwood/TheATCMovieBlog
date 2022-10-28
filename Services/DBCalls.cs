using TheATCMovieBlog.Data;
using TheATCMovieBlog.Models;

namespace TheATCMovieBlog.Services;

public class DBCalls : IDBCalls
{


    private readonly ApplicationDbContext _context;

    public DBCalls(ApplicationDbContext context)
    {
        _context = context;

    }

    // from[identifier] in [data source]
    // let[expression]
    // where[boolean expression]
    // order by[[expression] (ascending/descending)], [optionally repeat]
    // select[expression]
    // group[expression] by[expression] into[expression]
    public IEnumerable<Cast> CastQuery(Guid ID)
    {

        var query = from c in _context.Cast
                    where c.MovieID == ID
                    select c;

        return query;
    }
}
