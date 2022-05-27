using MovieApi.Core.Domain;
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
            movie.UpdatedAt = DateTime.Now;
            return _movieDataProvider.Update(movie);
        }
    }
}
