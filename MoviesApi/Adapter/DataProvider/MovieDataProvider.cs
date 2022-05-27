using MovieApi.Core.Domain;
using MoviesApi.Adapter.Extensions;
using MoviesApi.Adapter.Repository;
using MoviesApi.Core.DataProvider;

namespace MoviesApi.Adapter.DataProvider
{
    public class MovieDataProvider : IMovieDataProvider
    {

        private readonly MovieRepository _movieRepository;

        public MovieDataProvider(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        
        public Movie Create(Movie movie)
        {
            var movieModel = movie.ToMovieModel();
            _movieRepository.Create(movieModel);
            return movieModel.ToMovie();

        }

        public Movie? Find(string id) =>
            _movieRepository.Find(id)?.ToMovie();
            

        public Movie? Find(string director, string title) =>
            _movieRepository.Find(director, title)?.ToMovie();

        public List<Movie> FindAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Movie Update(Movie movie)
        {
            var movieModel = movie.ToMovieModel();
            _movieRepository.Update(movieModel.Id, movieModel);
            return movieModel.ToMovie();
        }
    }
}
