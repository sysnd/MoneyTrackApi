using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.UsersRepository
{
    public class UsersRepository : BaseRepository<User>, IUserRepository
    {
        public UsersRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.UsersCollectionName);
        }
    }
}
