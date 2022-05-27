using MovieApi.Core.Domain;

namespace MoviesApi.Core.DataProvider
{
    public interface IMovieDataProvider
    {
        public Movie? Find(string id);

        public Movie? Find(string director, string title);

        public List<Movie> FindAll();

        public Movie Create(Movie movie);

        public Movie Update(Movie movie);

        public void Remove(string id);
    }
}
