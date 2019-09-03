using System;
using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.UserService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/user
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var users = userService.Get();
                return Ok(users);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/user/id
        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult Get(string id)
        {
            try
            {
                var user = userService.Get(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/user
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                var status = userService.Create(user);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/user/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] User user)
        {
            try
            {
                var status = userService.Update(id, user);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/user/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = userService.Remove(id);
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