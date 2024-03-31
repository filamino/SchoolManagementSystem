using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? Department1 { get; set; }

    public string? HeadOfDepartment { get; set; }

    public DateOnly? DepartmentStartDate { get; set; }

    public int? NumberOfStudent { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
