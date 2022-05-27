using System.ComponentModel.DataAnnotations;

namespace MovieApi.Core.Domain
{
    public class Movie
    {
        public string? Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Director { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public int Duration { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Director)}: {Director}," +
            $" {nameof(Genre)}: {Genre}, {nameof(Duration)}: {Duration}," +
            $" {nameof(CreatedAt)}: {CreatedAt}, {nameof(UpdatedAt)}: {UpdatedAt}";
    }
}
