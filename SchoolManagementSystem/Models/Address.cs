using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
