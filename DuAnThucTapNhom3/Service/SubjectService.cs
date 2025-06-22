using System.Collections.Generic;
using System.Threading.Tasks;
using DuAnThucTapNhom3.Models;
using DuAnThucTapNhom3.Data;
using DuAnThucTapNhom3.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DuAnThucTapNhom3.Service
{
    public class SubjectService : ISubjectRepository
    {
        private readonly ApplicationDbContext _context;

        public SubjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SubjectModel>> GetAllAsync()
        {
            return await _context.Subjects
                .Include(s => s.SubjectType)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<SubjectModel> GetByIdAsync(string subjectCode)
        {
            return await _context.Subjects
                .Include(s => s.SubjectType)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.SubjectCode == subjectCode);
        }

        public async Task AddAsync(SubjectModel subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SubjectModel subject)
        {
            _context.Subjects.Update(subject);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string subjectCode)
        {
            var subject = await _context.Subjects.FindAsync(subjectCode);
            if (subject != null)
            {
                _context.Subjects.Remove(subject);
                await _context.SaveChangesAsync();
            }
        }
    }
}
