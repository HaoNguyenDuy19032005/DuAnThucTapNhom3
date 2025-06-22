using System.Collections.Generic;
using System.Threading.Tasks;
using DuAnDemo2API.Models;

namespace DuAnDemo2API.IRepository
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
