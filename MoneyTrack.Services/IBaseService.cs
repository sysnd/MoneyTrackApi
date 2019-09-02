using MoneyTrack.Data.Models;
using System.Collections.Generic;

namespace MoneyTrack.Services
{
    public interface IBaseService<T> where T:BaseModel
    {
        List<T> Get();
        T Get(string id);
        T Create(T type);

        bool Update(string id, T type);

        bool Remove(T type);

        bool Remove(string id);
    }
}
