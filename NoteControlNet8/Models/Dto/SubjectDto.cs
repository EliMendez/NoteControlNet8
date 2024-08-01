using System.ComponentModel.DataAnnotations;

namespace NoteControlNet8.Models.Dto
{
    public class SubjectDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
