using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyTrackShared.Configuration
{
    public interface IMoneyTrackDbConfig
    {
        string TypesCollectionName { get; set; }
        string BugdetsCollectionName { get; set; }
        string IncomeCollectionName { get; set; }
        string ExpensesCollectionName { get; set; }
        string AlertsCollectionName { get; set; }
        string UsersCollectionName { get; set; }
        string CategoriesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
