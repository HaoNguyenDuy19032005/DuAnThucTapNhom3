using System.Collections.Generic;
using System.Threading.Tasks;
using DuAnThucTapNhom3.Models;

namespace DuAnThucTapNhom3.IRepository
{
    public interface ISubjectTypeRepository
    {
        Task<IEnumerable<SubjectTypeModel>> GetAllAsync();
        Task<SubjectTypeModel> GetByIdAsync(int id);
        Task AddAsync(SubjectTypeModel subjectType);
        Task UpdateAsync(SubjectTypeModel subjectType);
        Task DeleteAsync(int id);
    }
}
