using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department? Department { get; set; } 

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
