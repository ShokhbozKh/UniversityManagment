using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagment.Entities;

public class Course
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
    public int Id { get; set; }
    [Required,MinLength(3,ErrorMessage ="3 tadan kup belgi bulsin")]
    [DisplayName("Course Name")]
    public string Name { get; set; }
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }=decimal.Zero;
    [Required]
    public int Hours { get; set; }
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime DateOfRegister { get; set; } = DateTime.Now;

    public int DepartamentId {  get; set; }
    [DisplayName("Department Name")]//// index da kurinadi tepada bulsa create da kurinadi
    [ForeignKey(nameof(DepartamentId))]
    [DeleteBehavior(DeleteBehavior.NoAction)]    
    public Department? Departments { get; set; }

    public virtual ICollection<CourseAssignment> CourseAssignments { get; set; }

    public Course()
    {
        CourseAssignments = new List<CourseAssignment>();
    }

}
