using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeacherHelper.Models
{
    public class Logbook
    {
        [Key]
        public int Id { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public DateTime Date { get; }
        public int? TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

    }
}
