using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.TypeService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService typesService;
        public TypeController(ITypeService typesService)
        {
            this.typesService = typesService;
        }

        // GET: api/types
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var types = typesService.Get();
                return Ok(types);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/types/id
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(string id)
        {
            try
            {
                var type = typesService.Get(id);
                return Ok(type);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/types
        [HttpPost]
        public ActionResult Post([FromBody] Type type)
        {
            try
            {
                var status = typesService.Create(type);
                return Ok(status);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/types/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Type type)
        {
            try
            {
                var status = typesService.Update(id, type);
                return Ok(status);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/types/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = typesService.Remove(id);
                return Ok(status);
            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}
