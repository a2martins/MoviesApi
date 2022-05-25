using MovieApi.Core.Domain;

namespace MovieApi.Core.Service
{
    public interface IUpsertMovie
    {
        void Execute(Movie movie);
    }
}
