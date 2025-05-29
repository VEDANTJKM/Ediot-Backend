using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Vmsforexportattend
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Personid { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Late { get; set; }

    public string? Early { get; set; }

    public string? Checkin { get; set; }

    public string? Checkout { get; set; }

    public string? Hours { get; set; }

    public string? Gender { get; set; }

    public string? Typeofemployee { get; set; }

    public DateOnly? Date { get; set; }

    public string? DayAttendance { get; set; }

    public string? Overtime { get; set; }

    public string? Shift { get; set; }
}
