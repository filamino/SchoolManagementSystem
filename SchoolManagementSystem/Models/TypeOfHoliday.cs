using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class TypeOfHoliday
{
    public int TypeOfHolidayId { get; set; }

    public string? TypeOfHoliday1 { get; set; }

    public virtual ICollection<Holiday> Holidays { get; set; } = new List<Holiday>();
}
