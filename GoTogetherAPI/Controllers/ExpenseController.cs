using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Helps users set track expenses.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        //private readonly IExpenseService _expenseService;

        //public ExpenseController(IExpenseService expenseService)
        //{
        //    _expenseService = expenseService;
        //}

        //[HttpPost]
        //public IActionResult AddExpense([FromBody] ExpenseDto expense)
        //{
        //    _expenseService.AddExpense(expense);
        //    return Ok();
        //}

        //[HttpGet("budget/{budgetId}/expenses")]
        //public IActionResult GetExpensesByBudget(int budgetId)
        //{
        //    var expenses = _expenseService.GetExpensesByBudgetId(budgetId);
        //    return Ok(expenses);
        //}
    }

}
