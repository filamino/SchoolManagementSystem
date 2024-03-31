using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Login
{
    public int LoginId { get; set; }

    public int UserId { get; set; }

    public virtual Register User { get; set; } = null!;
}
