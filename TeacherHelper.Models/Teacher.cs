using System.ComponentModel.DataAnnotations;

namespace TeacherHelper.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public List<Grade> Grades { get; set; }
        public List<Logbook> Logbooks { get; set; }

    }
}
