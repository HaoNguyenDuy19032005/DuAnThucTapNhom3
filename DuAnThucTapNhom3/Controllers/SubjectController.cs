using Microsoft.AspNetCore.Mvc;
using DuAnDemo2API.IRepository;
using DuAnDemo2API.Models;

namespace DuAnDemo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository _repo;

        public SubjectController(ISubjectRepository repo)
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
        public async Task<IActionResult> Create([FromBody] SubjectModel model)
        {
            await _repo.AddAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.SubjectCode }, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] SubjectModel model)
        {
            if (id != model.SubjectCode)
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
