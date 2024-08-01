using NoteControlNet8.Models;

namespace NoteControlNet8.Repository.Interface
{
    public interface ISubject
    {
        Task<ICollection<Subject>> GetAll();
    }
}
