using MovieApi.Core.Domain;
using MoviesApi.Core.DataService;

namespace MoviesApi.Core.Service.Impl
{
    public class SearchAllMovie : ISearchAllMovie
    {
        private readonly IMovieDataService _movieDataService;

        public SearchAllMovie(IMovieDataService movieDataService)
        {
            _movieDataService = movieDataService;
        }
        
        public List<Movie> Execute() =>
            _movieDataService.FindAll();
    }
}
