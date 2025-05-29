using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VmsattendanceShiftchangedataHistory
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? PersonId { get; set; }

    public string? PersonName { get; set; }

    public string? Organization { get; set; }

    public string? Shift { get; set; }

    public string? OffDay { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Month { get; set; }

    public string? History { get; set; }

    public string? Year { get; set; }
}
