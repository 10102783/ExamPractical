using ExamPractical.Data;
using ExamPractical.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamPractical.Services
{
    public class LecturerService
    {
        private readonly ApplicationDbContext _context;

        public LecturerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lecturer>> GetAllLecturersAsync()
        {
            return await _context.Lecturers.ToListAsync();
        }

        public async Task<Lecturer> GetLecturerByIdAsync(int id)
        {
            return await _context.Lecturers.FindAsync(id);
        }

        public async Task AddLecturerAsync(Lecturer lecturer)
        {
            _context.Lecturers.Add(lecturer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLecturerAsync(Lecturer lecturer)
        {
            _context.Lecturers.Update(lecturer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLecturerAsync(int id)
        {
            var lecturer = await _context.Lecturers.FindAsync(id);
            if (lecturer == null)
            {
                throw new KeyNotFoundException("Lecturer not found.");
            }

            _context.Lecturers.Remove(lecturer);
            await _context.SaveChangesAsync();
        }
    }
}
