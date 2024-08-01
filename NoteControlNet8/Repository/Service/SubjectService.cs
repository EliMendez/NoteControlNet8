using Microsoft.EntityFrameworkCore;
using NoteControlNet8.Data;
using NoteControlNet8.Models;
using NoteControlNet8.Repository.Interface;

namespace NoteControlNet8.Repository.Service
{
    public class SubjectService : ISubject
    {
        private readonly ApplicationDbContext _db;

        public SubjectService(ApplicationDbContext db) 
        { 
            _db = db;
        }

        public async Task<ICollection<Subject>> GetAll()
        {
            return await _db.Subject.OrderBy(c => c.Name).ToListAsync();
        }
    }
}
