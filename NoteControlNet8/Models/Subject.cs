using System.ComponentModel.DataAnnotations;

namespace NoteControlNet8.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The code is required.")]
        [StringLength(10, ErrorMessage = "The name can't be more than 10 characters.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [StringLength(25, ErrorMessage = "The name can't be more than 25 characters.")]
        public string Name { get; set; }

        [StringLength(150, ErrorMessage = "The name can't be more than 150 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The created date is required.")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "The updated date is required.")]
        public DateTime UpdatedDate { get; set; }
    }
}
