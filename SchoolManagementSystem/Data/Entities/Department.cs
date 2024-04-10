using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? Department1 { get; set; }

    public string? HeadOfDepartment { get; set; }

    public DateOnly? DepartmentStartDate { get; set; }

    public int? NumberOfStudent { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
