using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.TypesRepository
{
    public class TypesRepository : BaseRepository<Type>, ITypeRepository
    {
        public TypesRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.TypesCollectionName);
        }
    }
}
