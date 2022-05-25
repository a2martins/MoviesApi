using MovieApi.Adapter.Model;

namespace MoviesApi.Core.Repository
{
    public interface IMovieRepository
    {
        public Movie? Find(string id);

        public Movie? Find(string director, string title);

        public List<Movie> FindAll();

        public void Create(Movie movie);

        public void Update(string id, Movie movieIn);

        public void Remove(string id);
    }
}
