using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieApi.Adapter.Model
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
