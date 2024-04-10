using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string? FullName { get; set; }

    public int? MobileNo { get; set; }

    public string? Role { get; set; }

    public int UserId { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Register User { get; set; } = null!;
}
