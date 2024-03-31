using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Holiday
{
    public int HolidayId { get; set; }

    public string? HolidayName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int TypeOfHolidayId { get; set; }

    public virtual TypeOfHoliday TypeOfHoliday { get; set; } = null!;
}
