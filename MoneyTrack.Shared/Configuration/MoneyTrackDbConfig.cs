namespace MoneyTrackShared.Configuration
{
    public class MoneyTrackDbConfig : IMoneyTrackDbConfig
    {
        public string TypesCollectionName { get; set; }
        public string BugdetsCollectionName { get; set; }
        public string IncomeCollectionName { get; set; }
        public string ExpensesCollectionName { get; set; }
        public string AlertsCollectionName { get; set; }
        public string UsersCollectionName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
