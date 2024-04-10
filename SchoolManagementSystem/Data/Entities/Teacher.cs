using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

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

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Gender? Gender { get; set; }
}
