using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityManagment.Enums;

namespace UniversityManagment.Entities
{
    public class Student
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MinLength(4,ErrorMessage ="4 ta belgidan kup bo'lsin")]
        public string FullName { get; set; }

        [Required]
        public CourseNumbers CourseNumer { get; set; } = CourseNumbers.First;

        [Required]
        [DataType(DataType.Date)]
        public DateOnly DateOfBirth { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
