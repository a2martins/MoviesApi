using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Adapter.Model
{
    internal class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
    }
}
