using System.ComponentModel.DataAnnotations;

namespace lab12.Models.Common
{
    public class Courses:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(500)]
        public string Description { get; set; }
        [Range(0, 100000)]
        public decimal Price { get; set; }
        [Required]
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
