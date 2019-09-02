using MoneyTrack.Data.Models;
using System.Collections.Generic;

namespace MoneyTrack.Core.Repositories.BaseRepository
{
    interface IBaseRepository<T> where T:BaseModel
    {
        List<T> Get();

        T Get(string id);

        T Create(T t);

        void Update(string id, T t);

        void Remove(T bookIn);

        void Remove(string id);
    }
}
