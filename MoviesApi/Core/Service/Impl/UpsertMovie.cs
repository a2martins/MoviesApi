using MovieApi.Core.Domain;
using MoviesApi.Core.Repository;

namespace MovieApi.Core.Service.Impl
{
    internal class UpsertMovie : IUpsertMovie
    {
        private readonly IMovieRepository _movieRepository;

        public UpsertMovie(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        
        public void Execute(Movie movie)
        {
            var foundMovie = _movieRepository.Find(movie.Director, movie.Title);
            Console.WriteLine($"Found movie: {foundMovie}");
            //.Match(
            //    Some: m => _movieRepository.Update(m.Id, movie),
            //    None: () => _movieRepository.Create(movie)
            //);
        }
    }
}
