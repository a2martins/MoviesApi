using MovieApi.Core.Domain;
using MoviesApi.Core.CustomException;
using MoviesApi.Core.DataProvider;

namespace MoviesApi.Core.Service.Impl
{
    public class UpdateMovie : IUpdateMovie
    {

        private readonly IMovieDataProvider _movieDataProvider;

        public UpdateMovie(IMovieDataProvider movieDataProvider)
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
