using MovieApi.Core.Domain;
using MoviesApi.Adapter.Extensions;
using MoviesApi.Adapter.Repository;
using MoviesApi.Core.DataService;

namespace MoviesApi.Adapter.DataService
{
    public class MovieDataService : IMovieDataService
    {

        private readonly MovieRepository _movieRepository;

        public MovieDataService(MovieRepository movieRepository)
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

        public List<Movie> FindAll() =>
            _movieRepository.FindAll().ToMovieList();

        public bool Remove(string id) =>
            _movieRepository.Remove(id) > 0;

        public Movie Update(Movie movie)
        {
            var movieModel = movie.ToMovieModel();
            _movieRepository.Update(movieModel.Id, movieModel);
            return movieModel.ToMovie();
        }
    }
}
