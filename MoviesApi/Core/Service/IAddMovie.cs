using MovieApi.Core.Domain;

namespace MoviesApi.Core.Service
{
    public interface IAddMovie
    {
        Movie Execute(Movie movie);
    }
}
