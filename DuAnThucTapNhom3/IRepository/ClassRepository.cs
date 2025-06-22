using DuAnThucTapNhom3.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DuAnThucTapNhom3.IRepository;

public interface IClassRepository
{
    Task<IEnumerable<ClassModel>> GetAllAsync();
    Task<ClassModel> GetByIdAsync(string classCode);
    Task AddAsync(ClassModel classModel);
    Task UpdateAsync(ClassModel classModel);
    Task DeleteAsync(string classCode);
}