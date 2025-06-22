using Microsoft.AspNetCore.Mvc;
using DuAnThucTapNhom3.IRepository;
using DuAnThucTapNhom3.Models;

namespace DuAnThucTapNhom3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _repo;

        public ClassController(IClassRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var data = await _repo.GetByIdAsync(id);
            return data == null ? NotFound() : Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClassModel model)
        {
            await _repo.AddAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.ClassCode }, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] ClassModel model)
        {
            if (id != model.ClassCode)
                return BadRequest();

            await _repo.UpdateAsync(model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}