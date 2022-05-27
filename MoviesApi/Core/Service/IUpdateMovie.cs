using MovieApi.Core.Domain;

namespace MoviesApi.Core.Service
{
    public interface IUpdateMovie
    {
        Movie Execute(Movie movie);
    }
}
