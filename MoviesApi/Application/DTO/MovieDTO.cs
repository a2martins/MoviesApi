using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Application.Controller.DTO
{
    public class MovieDTO
    {
        public string? Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 180)]
        public int Duration { get; set; }

        public DateTime? CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }

        public override string ToString() =>
            $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Director)}: {Director}, {nameof(Genre)}: {Genre}, {nameof(Duration)}: {Duration}, {nameof(CreatedAt)}: {CreatedAt}, {nameof(UpdatedAt)}: {UpdatedAt}";
    }
}
