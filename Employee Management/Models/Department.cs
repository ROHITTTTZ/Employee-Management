using System.ComponentModel.DataAnnotations;

namespace Employee_Management.Models
{
    public class Department
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
