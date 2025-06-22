using DuAnThucTapNhom3.IRepository;
using DuAnThucTapNhom3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuAnThucTapNhom3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectTypeController : ControllerBase
    {
        private readonly ISubjectTypeRepository _repo;

        public SubjectTypeController(ISubjectTypeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            return data == null ? NotFound() : Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SubjectTypeModel model)
        {
            await _repo.AddAsync(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SubjectTypeModel model)
        {
            if (id != model.SubjectTypeID) return BadRequest();
            await _repo.UpdateAsync(model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}