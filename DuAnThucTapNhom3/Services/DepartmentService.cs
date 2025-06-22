using DuAnThucTapNhom3.Data;
using DuAnThucTapNhom3.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAnThucTapNhom3.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetAllAsync() =>
            await _context.Department.ToListAsync();

        public async Task<Department?> GetByIdAsync(int id) =>
            await _context.Department.FindAsync(id);

        public async Task<Department> CreateAsync(Department model)
        {
            model.CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            model.UpdatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            _context.Department.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<bool> UpdateAsync(int id, Department updated)
        {
            var existing = await _context.Department.FindAsync(id);
            if (existing == null) return false;

            existing.DepartmentName = updated.DepartmentName;
            existing.Description = updated.Description;
            existing.UpdatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var department = await _context.Department.FindAsync(id);
            if (department == null) return false;

            _context.Department.Remove(department);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
