using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string AdmissionNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly? JoinedDate { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }

    public string? About { get; set; }

    public byte[]? Image { get; set; }

    public int GenderId { get; set; }

    public int AddressId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;
}
