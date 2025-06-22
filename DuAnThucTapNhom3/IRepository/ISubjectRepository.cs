using System.Collections.Generic;
using System.Threading.Tasks;
using DuAnDemo2API.Models;

namespace DuAnDemo2API.IRepository
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<SubjectModel>> GetAllAsync();
        Task<SubjectModel> GetByIdAsync(string subjectCode);
        Task AddAsync(SubjectModel subject);
        Task UpdateAsync(SubjectModel subject);
        Task DeleteAsync(string subjectCode);
    }
}
