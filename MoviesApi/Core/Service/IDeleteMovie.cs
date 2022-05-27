using MovieApi.Core.Domain;

namespace MoviesApi.Core.Service
{
    public interface IDeleteMovie
    {
        Movie Execute(string id);
    }
}
