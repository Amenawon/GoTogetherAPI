using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Helps users set travel budgets and track expenses.

namespace GoTogether.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        //private readonly IBudgetService _budgetService;

        //public BudgetController(IBudgetService budgetService)
        //{
        //    _budgetService = budgetService;
        //}

        //[HttpPost]
        //public IActionResult CreateBudget([FromBody] BudgetDto budget)
        //{
        //    _budgetService.CreateBudget(budget);
        //    return Ok();
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetBudget(int id)
        //{
        //    var budget = _budgetService.GetBudgetById(id);
        //    return budget == null ? NotFound() : Ok(budget);
        //}
    }
}
