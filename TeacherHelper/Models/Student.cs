using System.ComponentModel.DataAnnotations;

namespace TeacherHelper.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        public Grade Grade { get; set; }
    }
}
