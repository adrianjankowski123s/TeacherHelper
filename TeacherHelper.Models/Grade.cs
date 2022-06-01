using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherHelper.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }
    }
}
