using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptPeriodicActionItem
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? ProcessName { get; set; }

    public string? ResponsiblePerson { get; set; }

    public string? ResponsiblePersonName { get; set; }

    public string? ProcessReview { get; set; }

    public string? ReferenceDocument { get; set; }

    public string? UploadBy { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Department { get; set; }

    public string? Frequency { get; set; }
}
