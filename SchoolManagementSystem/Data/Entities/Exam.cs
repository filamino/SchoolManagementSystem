using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Exam
{
    public int ExamId { get; set; }

    public string? ExamName { get; set; }

    public DateOnly? ExamDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public int SubjectId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
