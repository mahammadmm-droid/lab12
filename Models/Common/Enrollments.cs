using System.ComponentModel.DataAnnotations;

namespace lab12.Models.Common
{
    public class Enrollment:BaseEntity
    {
        [Required]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        [Required]
        public int CourseId { get; set; }
        public Courses Courses { get; set; }
    }
}
