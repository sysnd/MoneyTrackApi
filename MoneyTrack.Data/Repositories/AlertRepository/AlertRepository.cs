using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.AlertsRepository
{
    public class AlertRepository : BaseRepository<Alert>, IAlertRepository
    {
        public AlertRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.AlertsCollectionName);
        }
    }
}
