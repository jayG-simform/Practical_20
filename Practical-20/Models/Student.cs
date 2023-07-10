using System.ComponentModel.DataAnnotations;

namespace Practical_20.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Student name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Age is required")]
        public int Age { get; set; }
    }
}
