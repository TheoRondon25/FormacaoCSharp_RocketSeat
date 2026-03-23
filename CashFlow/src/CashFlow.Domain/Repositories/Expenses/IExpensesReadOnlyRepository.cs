using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesReadOnlyRepository
{
    Task<List<Expense>> GetAll();
    Task<Expense?> GetById(long id);
}
