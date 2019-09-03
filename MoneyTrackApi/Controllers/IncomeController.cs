using System;
using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.IncomeService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService incomeService;
        public IncomeController(IIncomeService incomeService)
        {
            this.incomeService = incomeService;
        }
        // GET: api/income
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var incomes = incomeService.Get();
                return Ok(incomes);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/income/id
        [HttpGet("{id}", Name = "GetIncome")]
        public ActionResult Get(string id)
        {
            try
            {
                var income = incomeService.Get(id);
                return Ok(income);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/income
        [HttpPost]
        public ActionResult Post([FromBody] Income income)
        {
            try
            {
                var status = incomeService.Create(income);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/income/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Income income)
        {
            try
            {
                var status = incomeService.Update(id, income);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/income/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = incomeService.Remove(id);
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