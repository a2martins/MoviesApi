using MovieApi.Core.Domain;
using MoviesApi.Core.CustomException;
using MoviesApi.Core.DataService;

namespace MoviesApi.Core.Service.Impl
{
    public class SearchOneMovie : ISearchOneMovie
    {

        private readonly IMovieDataService _movieDataService;

        public SearchOneMovie(IMovieDataService movieDataService)
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

            return foundMovie;
        }
    }
}
