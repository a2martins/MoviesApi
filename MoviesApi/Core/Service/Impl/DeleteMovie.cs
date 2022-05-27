using MovieApi.Core.Domain;
using MoviesApi.Core.CustomException;
using MoviesApi.Core.DataService;

namespace MoviesApi.Core.Service.Impl
{
    public class DeleteMovie : IDeleteMovie
    {
        private readonly IMovieDataService _movieDataService;

        public DeleteMovie(IMovieDataService movieDataService)
        {
            _movieDataService = movieDataService;
        }

        public Movie Execute(string id)
        {
            var foundMovie = _movieDataService.Find(id);
            if (foundMovie == null)
            {
                throw new MovieNotFoundException(id);
            }
            
            var deleted = _movieDataService.Remove(id);
            if (!deleted)
            {
                throw new MovieNotDeletedException(id);
            }

            return foundMovie;
        }
    }
}
