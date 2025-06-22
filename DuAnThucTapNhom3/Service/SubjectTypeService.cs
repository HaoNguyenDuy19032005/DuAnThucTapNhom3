using System.Collections.Generic;
using System.Threading.Tasks;
using DuAnDemo2API.Models;
using DuAnDemo2API.Data;
using DuAnDemo2API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DuAnDemo2API.Service
{
    public class SubjectTypeService : ISubjectTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public SubjectTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubjectTypeModel>> GetAllAsync()
        {
            return await _context.SubjectTypes.AsNoTracking().ToListAsync();
        }

        public async Task<SubjectTypeModel> GetByIdAsync(int id)
        {
            return await _context.SubjectTypes.FindAsync(id);
        }

        public async Task AddAsync(SubjectTypeModel subjectType)
        {
            _context.SubjectTypes.Add(subjectType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SubjectTypeModel subjectType)
        {
            _context.SubjectTypes.Update(subjectType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.SubjectTypes.FindAsync(id);
            if (item != null)
            {
                _context.SubjectTypes.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
