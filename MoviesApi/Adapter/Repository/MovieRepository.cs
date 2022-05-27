using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieApi.Adapter.Model;
using MoviesApi.Adapter.Model.Setting;

namespace MoviesApi.Adapter.Repository
{
    public class MovieRepository
    {
        private readonly IMongoCollection<MovieModel> _mongoCollection;

        public MovieRepository(IOptions<MovieStoreDatabaseSettings> movieStoreDBSettings)
        {
            var client = new MongoClient(movieStoreDBSettings.Value.ConnectionString);
            var database = client.GetDatabase(movieStoreDBSettings.Value.DatabaseName);
            _mongoCollection = database.GetCollection<MovieModel>(movieStoreDBSettings.Value.CollectionName);
        }

        public MovieModel? Find(string id) =>
            _mongoCollection.Find(movie => movie.Id == id).FirstOrDefault();

        public MovieModel? Find(string director, string title) =>
            _mongoCollection.Find(movie => movie.Director == director && movie.Title == title).FirstOrDefault();

        public List<MovieModel> FindAll() =>
            _mongoCollection.Find(movie => true).ToList();

        public void Create(MovieModel movie) =>
            _mongoCollection.InsertOne(movie);

        public void Update(string id, MovieModel movieIn)
        {
            Console.WriteLine(Find(id));
            var ros = _mongoCollection.ReplaceOne(movie => movie.Id == id, movieIn);
            Console.WriteLine(ros.ModifiedCount);
            Console.WriteLine(ros.ToString());
        }
        
        public long Remove(string id)
        {
            var deleteResult = _mongoCollection.DeleteOne(movie => movie.Id == id);
            return deleteResult.DeletedCount;
        }

    }
}
