using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TeacherHelper.Models
{
    public class Logbook
    {
        [Key]
        public int Id { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public DateTime Date { get; }
    }
}
