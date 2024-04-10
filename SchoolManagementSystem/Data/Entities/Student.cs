using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

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

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Gender> Genders { get; set; } = new List<Gender>();
}
