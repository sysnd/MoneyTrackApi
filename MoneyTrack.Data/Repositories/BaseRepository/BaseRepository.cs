using MoneyTrack.Data.Models;
using MoneyTrackShared.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MoneyTrack.Data.Repositories.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private IMongoCollection<T> _items;
        private IMongoDatabase _database;

        public BaseRepository(IMoneyTrackDbConfig settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }
        public virtual void Init(string collectionName)
        {
            _items = _database.GetCollection<T>(collectionName);
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

        public bool Remove(T t)
        {
            var itemToDelete = _items.DeleteOne(x => x.Id == t.Id);
            return itemToDelete.IsAcknowledged;
        }

        public bool Remove(string id)
        {
            var itemToDelete = _items.DeleteOne(x => x.Id == id);
            return itemToDelete.IsAcknowledged;
        }

        public bool Update(string id, T t)
        {
            var itemToDelete = _items.ReplaceOne(x => x.Id == id, t);
            return itemToDelete.IsAcknowledged;
        }
    }
}
