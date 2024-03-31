using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public int TeacherNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public int? MobileNumber { get; set; }

    public DateOnly? JoinedDate { get; set; }

    public string? Qualification { get; set; }

    public string? Experience { get; set; }

    public int AddressId { get; set; }

    public int SectionId { get; set; }

    public int GenderId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;
}
