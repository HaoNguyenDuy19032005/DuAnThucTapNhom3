using DuAnThucTapNhom3.Models;
using DuAnThucTapNhom3.Services;
using Microsoft.AspNetCore.Mvc;

namespace DuAnThucTapNhom3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }

        /// <summary>
        /// Lấy danh sách tất cả các phòng ban.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Department>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _service.GetAllAsync();
            return Ok(departments);
        }

        /// <summary>
        /// Lấy thông tin phòng ban theo ID.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Department), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        /// <summary>
        /// Tạo mới một phòng ban.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(Department), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] Department model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _service.CreateAsync(model);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        /// <summary>
        /// Cập nhật thông tin phòng ban theo ID.
        /// </summary>
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] Department model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _service.UpdateAsync(id, model);
            return success ? NoContent() : NotFound();
        }

        /// <summary>
        /// Xoá phòng ban theo ID.
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _service.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }
    }
}
