using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagment.Entities
{
    public class Instructor
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MinLength(4,ErrorMessage ="kamida 4 ta belgi bo'lsin")]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MinLength(4,ErrorMessage ="kamida 4 ta belgi bo'lsin")]
        public string LastName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int DepartmentId { get; set; }
        public Department? Departments { get; set; }

        public virtual ICollection<CourseAssignment> CourseAssignments { get; set; }
        public Instructor()
        {
            CourseAssignments = new List<CourseAssignment>();
        }


    }
}
