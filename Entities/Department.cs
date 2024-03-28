using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagment.Entities
{
    public class Department
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(20,ErrorMessage ="20 ta belgidan kup bulmasin")]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

        public Department()
        {
            Courses = new List<Course>();
            Instructors = new List<Instructor>();
        }
    }
}
