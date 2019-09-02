using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.BudgetRepository;
using System.Collections.Generic;

namespace MoneyTrack.Services.BudgetService
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetRepository budgetRepository;

        public BudgetService(IBudgetRepository budgetRepository)
        {
            this.budgetRepository = budgetRepository;
        }
        public Budget Create(Budget budget)
        {
            return budgetRepository.Create(budget);
        }

        public List<Budget> Get()
        {
            return budgetRepository.Get();
        }

        public Budget Get(string id)
        {
            return budgetRepository.Get(id);
        }

        public bool Remove(Budget budget)
        {
            return budgetRepository.Remove(budget);
        }

        public bool Remove(string id)
        {
            return budgetRepository.Remove(id);
        }

        public bool Update(string id, Budget budget)
        {
            return budgetRepository.Update(id, budget);
        }
    }
}
