using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BaseRepository;
namespace MoneyTrack.Data.Repositories.ExpensesRepository
{
    public interface IExpenseRepository : IBaseRepository<Expense>
    {
    }
}
