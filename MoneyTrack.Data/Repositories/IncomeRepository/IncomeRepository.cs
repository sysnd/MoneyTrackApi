using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.IncomeRepository
{
    public class IncomeRepository : BaseRepository<Income>, IIncomeRepository
    {
        public IncomeRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.IncomeCollectionName);
        }
    }
}
