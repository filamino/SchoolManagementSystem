using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Register
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string ComfirmPassword { get; set; } = null!;

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
