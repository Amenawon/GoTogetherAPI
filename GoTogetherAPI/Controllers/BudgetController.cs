using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoTogether.Core.DTO;
using GoTogether.Core.Interface;
using Microsoft.AspNetCore.Mvc;

// Helps users set travel budgets and track expenses.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService _budgetService;

        public BudgetController(IBudgetService budgetService)
        {
            _budgetService = budgetService;
        }

        [HttpPost]
        public IActionResult CreateBudget([FromBody] CreateBudgetDto budget)
        {
            string userId = "0";
            _budgetService.CreateBudget(userId,budget);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBudget(string id)
        {
            var budget = _budgetService.GetBudget(id);
            return budget == null ? NotFound() : Ok(budget);
        }
    }
}
