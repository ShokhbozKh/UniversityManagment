using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagment.Entities
{
    public class Enrollment
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int StudentId { get; set; }
        [ForeignKey(nameof(StudentId))]
        public Student? Students { get; set; }
        public int CourseAssignmentId { get; set; }
        [ForeignKey(nameof(CourseAssignmentId))]
        public CourseAssignment? CourseAssignments { get; set; }


    }
}
