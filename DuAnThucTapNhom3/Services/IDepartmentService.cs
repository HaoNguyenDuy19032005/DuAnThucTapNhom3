using DuAnThucTapNhom3.Models;

namespace DuAnThucTapNhom3.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<Department> CreateAsync(Department department);
        Task<bool> UpdateAsync(int id, Department updated);
        Task<bool> DeleteAsync(int id);
    }
}
