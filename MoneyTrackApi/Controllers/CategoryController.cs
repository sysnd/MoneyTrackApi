using System;
using Microsoft.AspNetCore.Mvc;
using MoneyTrack.Data.Models;
using MoneyTrack.Logging;
using MoneyTrack.Services.CategoryService;

namespace MoneyTrackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        // GET: api/category
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var categories = categoryService.Get();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // GET: api/category/id
        [HttpGet("{id}", Name = "GetCategory")]
        public ActionResult Get(string id)
        {
            try
            {
                var category = categoryService.Get(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // POST: api/category
        [HttpPost]
        public ActionResult Post([FromBody] Category category)
        {
            try
            {
                var status = categoryService.Create(category);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // PUT: api/category/id
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Category category)
        {
            try
            {
                var status = categoryService.Update(id, category);
                return Ok(status);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Type: {Type}. Message: {Message}", ex.GetType(), ex.Message);
                return BadRequest($"{ex.GetType()}: {ex.Message}");
            }
        }

        // DELETE: api/category/id
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var status = categoryService.Remove(id);
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