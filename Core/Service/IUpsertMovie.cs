using Core.Domain;

namespace Core.Service
{
    public interface IUpsertMovie
    {
        void Execute(Movie movie);
    }
}
