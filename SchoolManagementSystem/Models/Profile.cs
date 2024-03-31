using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string? FullName { get; set; }

    public int? MobileNo { get; set; }

    public string? Role { get; set; }

    public int AddressId { get; set; }

    public int? UserId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual Register? User { get; set; }
}
