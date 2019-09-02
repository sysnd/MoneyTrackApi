using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.BudgetRepository
{
    public class BudgetRepository : BaseRepository<Budget>, IBudgetRepository
    {
        public BudgetRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.BudgetsCollectionName);
        }
    }
}
