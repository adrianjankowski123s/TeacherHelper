using System.ComponentModel.DataAnnotations;

namespace TeacherHelper.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
