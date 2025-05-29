using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchGrade
{
    public int Id { get; set; }

    public int? InputSerialNumber { get; set; }

    public string? MaterialType { get; set; }

    public string? Grade { get; set; }

    public string? Category { get; set; }

    public int? PId { get; set; }

    public long? AdvLicno { get; set; }
}
