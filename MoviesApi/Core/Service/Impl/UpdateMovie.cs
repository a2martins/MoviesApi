using MovieApi.Core.Domain;
using MoviesApi.Core.CustomException;
using MoviesApi.Core.DataService;

namespace MoviesApi.Core.Service.Impl
{
    public class UpdateMovie : IUpdateMovie
    {

        private readonly IMovieDataService _movieDataProvider;

        public UpdateMovie(IMovieDataService movieDataProvider)
        {
            _movieDataProvider = movieDataProvider;
        }

        public Movie Execute(Movie movie)
        {
            var foundMovie = _movieDataProvider.Find(movie.Id!);
            if (foundMovie is null)
            {
                throw new MovieNotFoundException(movie.ToString());
            }

            movie.CreatedAt = foundMovie.CreatedAt;
            movie.UpdatedAt = DateTime.Now;
            return _movieDataProvider.Update(movie);
        }
    }
}
