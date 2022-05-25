using System.ComponentModel.DataAnnotations;

namespace MovieApi.Core.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 180)]
        public int Duration { get; set; }
    }
}
