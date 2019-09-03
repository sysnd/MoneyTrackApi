using System;
using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.BudgetService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService budgetService;
        public BudgetController(IBudgetService budgetService)
        {
            this.budgetService = budgetService;
        }
        // GET: api/budget
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var budgets = budgetService.Get();
                return Ok(budgets);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/budget/id
        [HttpGet("{id}", Name = "GetBudget")]
        public ActionResult Get(string id)
        {
            try
            {
                var budget = budgetService.Get(id);
                return Ok(budget);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/budget
        [HttpPost]
        public ActionResult Post([FromBody] Budget budget)
        {
            try
            {
                var status = budgetService.Create(budget);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/budget/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Budget budget)
        {
            try
            {
                var status = budgetService.Update(id, budget);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/budget/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = budgetService.Remove(id);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}