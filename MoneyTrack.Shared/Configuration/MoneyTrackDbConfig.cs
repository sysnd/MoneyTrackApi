using Microsoft.Extensions.Configuration;
using System.IO;

namespace MoneyTrackShared.Configuration
{
    public class MoneyTrackDbConfig : IMoneyTrackDbConfig
    {
        public MoneyTrackDbConfig()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
        }
        public string TypesCollectionName { get; set; }
        public string BudgetsCollectionName { get; set; }
        public string IncomeCollectionName { get; set; }
        public string ExpensesCollectionName { get; set; }
        public string AlertsCollectionName { get; set; }
        public string UsersCollectionName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
