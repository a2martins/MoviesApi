using MovieApi.Core.Domain;

namespace MoviesApi.Core.DataService
{
    public interface IMovieDataService
    {
        public Movie? Find(string id);

        public Movie? Find(string director, string title);

        public List<Movie> FindAll();

        public Movie Create(Movie movie);

        public Movie Update(Movie movie);

        public bool Remove(string id);
    }
}
