using MoneyTrack.Data.Models;
using System.Collections.Generic;

namespace MoneyTrack.Data.Repositories.BaseRepository
{
    public interface IBaseRepository<T> where T:BaseModel
    {
        List<T> Get();

        T Get(string id);

        T Create(T t);

        bool Update(string id, T t);

        bool Remove(T t);

        bool Remove(string id);
    }
}
