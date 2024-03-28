using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagment.Entities
{
    public class CourseAssignment
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MinLength(4,ErrorMessage ="Min lingth 4 characters")]
        public string Room {  get; set; }

        public int InstructorId { get; set; }
        [ForeignKey(nameof(InstructorId))]
        public Instructor? Instructors { get; set; }

        public int CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public Course? Courses { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public CourseAssignment()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
