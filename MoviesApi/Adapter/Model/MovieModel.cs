using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieApi.Adapter.Model
{
    public class MovieModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Director { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public int Duration { get; set; }
        
        public DateTime? CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
    }
}
