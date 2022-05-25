using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieApi.Adapter.Model;
using MoviesApi.Adapter.Model.Setting;
using MoviesApi.Core.Repository;

namespace MoviesApi.Adapter.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _mongoCollection;

        public MovieRepository(IOptions<MovieStoreDatabaseSettings> movieStoreDBSettings)
        {
            var client = new MongoClient(movieStoreDBSettings.Value.ConnectionString);
            var database = client.GetDatabase(movieStoreDBSettings.Value.DatabaseName);
            _mongoCollection = database.GetCollection<Movie>(movieStoreDBSettings.Value.CollectionName);
        }

        public Movie Find(string id) =>
            _mongoCollection.Find(movie => movie.Id == id).FirstOrDefault();

        public Movie Find(string director, string title) =>
            _mongoCollection.Find(movie => movie.Director == director && movie.Title == title).FirstOrDefault();

        public List<Movie> FindAll() =>
            _mongoCollection.Find(movie => true).ToList();

        public void Create(Movie movie) =>
            _mongoCollection.InsertOne(movie);

        public void Update(string id, Movie movieIn) =>
            _mongoCollection.ReplaceOne(movie => movie.Id == id, movieIn);

        public void Remove(string id) =>
            _mongoCollection.DeleteOne(movie => movie.Id == id);
    }
}
