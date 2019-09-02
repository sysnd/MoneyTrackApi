using System;
using System.Collections.Generic;
using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.ExpensesRepository;

namespace MoneyTrack.Services.ExpenseService
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository expensesRepository;

        public ExpenseService(IExpenseRepository expensesRepository)
        {
            this.expensesRepository = expensesRepository;
        }
        public Expense Create(Expense expense)
        {
            return expensesRepository.Create(expense);
        }

        public List<Expense> Get()
        {
            return expensesRepository.Get();
        }

        public Expense Get(string id)
        {
            return expensesRepository.Get(id);
        }

        public bool Remove(Expense expense)
        {
            return expensesRepository.Remove(expense);
        }

        public bool Remove(string id)
        {
            return expensesRepository.Remove(id);
        }

        public bool Update(string id, Expense expense)
        {
            return expensesRepository.Update(id, expense);
        }
    }
}
