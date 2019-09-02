using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.CategoriesRepository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.CategoriesCollectionName);
        }
    }
}
