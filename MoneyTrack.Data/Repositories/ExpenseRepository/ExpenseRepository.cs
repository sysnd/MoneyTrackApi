using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
using MoneyTrackShared.Configuration;

namespace MoneyTrack.Data.Repositories.ExpensesRepository
{
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(IMoneyTrackDbConfig settings) : base(settings)
        {
            Init(settings.ExpensesCollectionName);
        }
    }
}
