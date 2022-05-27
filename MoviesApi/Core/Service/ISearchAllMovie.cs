using MovieApi.Core.Domain;

namespace MoviesApi.Core.Service
{
    public interface ISearchAllMovie
    {
        List<Movie> Execute();
    }
}
