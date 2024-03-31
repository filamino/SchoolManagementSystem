using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderType { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
