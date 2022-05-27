using MovieApi.Core.Domain;

namespace MoviesApi.Core.Service
{
    public interface ISearchOneMovie
    {
        Movie Execute(string id);
    }
}
