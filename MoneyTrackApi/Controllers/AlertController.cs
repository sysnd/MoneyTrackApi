using System;
using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.AlertsService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : ControllerBase
    {
        private readonly IAlertService alertsService;
        public AlertController(IAlertService alertsService)
        {
            this.alertsService = alertsService;
        }
        // GET: api/alert
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var alerts = alertsService.Get();
                return Ok(alerts);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/alert/id
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(string id)
        {
            try
            {
                var alert = alertsService.Get(id);
                return Ok(alert);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/alert
        [HttpPost]
        public ActionResult Post([FromBody] Alert alert)
        {
            try
            {
                var status = alertsService.Create(alert);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/alert/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Alert alert)
        {
            try
            {
                var status = alertsService.Update(id,alert);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/alert/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = alertsService.Remove(id);
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
