using MovieApi.Core.Domain;
using MoviesApi.Application.Controller.DTO;

namespace MoviesApi.Application.Extensions
{
    internal static class MovieExtensions
    {
        internal static Movie ToMovie(this MovieDTO movieDTO) => new()
        {
            Id = movieDTO.Id,
            Director = movieDTO.Director,
            Genre = movieDTO.Genre,
            Title = movieDTO.Title,
            Duration = movieDTO.Duration,
            CreatedAt = movieDTO.CreatedAt,
            UpdatedAt = movieDTO.UpdatedAt
        };

        public static MovieDTO ToMovieDTO(this Movie movie) => new()
        {
            Id = movie.Id,
            Title = movie.Title,
            Director = movie.Director,
            Genre = movie.Genre,
            Duration = movie.Duration,
            CreatedAt = movie.CreatedAt,
            UpdatedAt = movie.UpdatedAt
        };
    }
}
