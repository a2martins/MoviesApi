using MongoDB.Bson;
using MovieApi.Adapter.Model;
using MovieApi.Core.Domain;

namespace MoviesApi.Adapter.Extensions
{
    public static class MovieExtensions
    {
        public static Movie ToMovie(this MovieModel movieModel) => new()
        {
            Id = movieModel.Id,
            Title = movieModel.Title,
            Genre = movieModel.Genre,
            Director = movieModel.Director,
            Duration = movieModel.Duration,
            CreatedAt = movieModel.CreatedAt,
            UpdatedAt = movieModel.UpdatedAt
        };

        public static MovieModel ToMovieModel(this Movie movie) => new()
        {
            Id = movie.Id ?? ObjectId.GenerateNewId().ToString(),
            Title = movie.Title,
            Genre = movie.Genre,
            Director = movie.Director,
            Duration = movie.Duration,
            CreatedAt = movie.CreatedAt,
            UpdatedAt = movie.UpdatedAt
        };
    }
}
