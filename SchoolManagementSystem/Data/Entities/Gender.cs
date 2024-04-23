using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderType { get; set; } = null!;

    public int StudentId { get; set; }

    public int TeacherId { get; set; }

    public virtual Teacher? Gender1 { get; set; }

    public virtual Profile? GenderNavigation { get; set; }

    public virtual Student? Student { get; set; }
}
