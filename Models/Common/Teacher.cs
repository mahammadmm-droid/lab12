using System.ComponentModel.DataAnnotations;

namespace lab12.Models.Common
{
    public class Teacher: BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        public List<Courses> Courses { get; set; } = new List<Courses>();
    }
}
