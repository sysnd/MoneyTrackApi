using MoneyTrack.Data.Models;
using MoneyTrackShared.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MoneyTrack.Core.Repositories.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T: BaseModel
    {
        private readonly IMongoCollection<T> _items;

        public BaseRepository(IMoneyTrackDbConfig settings, string collectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _items = database.GetCollection<T>(collectionName);
        }

        public T Create(T t)
        {
            _items.InsertOne(t);
            return t;
        }

        public List<T> Get()
        {
            return _items.Find(x => true).ToList();
        }

        public T Get(string id)
        {
            return _items.Find(x => x.Id == id).FirstOrDefault();
        }

        public void Remove(T t)
        {
            _items.DeleteOne(x=>x.Id==t.Id);
        }

        public void Remove(string id)
        {
            _items.DeleteOne(x => x.Id == id);
        }

        public void Update(string id, T t)
        {
            _items.ReplaceOne(x => x.Id == id, t);
        }
    }
}
