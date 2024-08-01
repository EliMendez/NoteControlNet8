using Microsoft.EntityFrameworkCore;
using NoteControlNet8.Models;

namespace NoteControlNet8.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Subject> Subject { get; set; }
    }
}
