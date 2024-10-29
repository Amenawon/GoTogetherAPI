using System;
using System.Threading.Tasks;
using GoTogether.Core.DTO;
using GoTogether.Core.Model;

namespace GoTogether.Core.Interface
{
    public interface IBudgetService
    {
        Task<Budget> GetBudget(string userId);
        Task<int> CreateBudget(string userId, CreateBudgetDto payload);
        Task<int> DeleteBudget(string userId);
    }
}
