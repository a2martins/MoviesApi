using MovieApi.Core.Domain;
using MoviesApi.Core.CustomException;
using MoviesApi.Core.DataProvider;

namespace MoviesApi.Core.Service.Impl
{
    internal class AddMovie : IAddMovie
    {
        private readonly IMovieDataProvider _movieDataProvider;

        public AddMovie(IMovieDataProvider movieDataProvider)
        {
            _movieDataProvider = movieDataProvider;
        }
        
        public Movie Execute(Movie movie) 
        {
            if (_movieDataProvider.Find(movie.Director, movie.Title) is not null)
            {
                throw new MovieAlreadyExistsException(movie.Title);
            }

            movie.CreatedAt = DateTime.Now;
            return _movieDataProvider.Create(movie);
        }
    }
}
