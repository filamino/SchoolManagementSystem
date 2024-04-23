using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public int StudentId { get; set; }

    public int TeacherId { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
