using System.Collections.Generic;
using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.IncomeRepository;
using MoneyTrack.Services.IncomeService;

namespace MoneyTrack.Services.IncomeServices
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository incomeRepository;

        public IncomeService(IIncomeRepository incomeRepository)
        {
            this.incomeRepository = incomeRepository;
        }
        public Income Create(Income income)
        {
            return incomeRepository.Create(income);
        }

        public List<Income> Get()
        {
            return incomeRepository.Get();
        }

        public Income Get(string id)
        {
            return incomeRepository.Get(id);
        }

        public bool Remove(Income income)
        {
            return incomeRepository.Remove(income);
        }

        public bool Remove(string id)
        {
            return incomeRepository.Remove(id);
        }

        public bool Update(string id, Income income)
        {
            return incomeRepository.Update(id, income);
        }
    }
}
