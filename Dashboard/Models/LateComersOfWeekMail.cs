using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class LateComersOfWeekMail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int? PersonId { get; set; }

    public string? PersonName { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public decimal? MinutesLate { get; set; }

    public string? DayOfWeek { get; set; }
}
