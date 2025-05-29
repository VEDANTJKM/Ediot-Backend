using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EmpTrialDatum
{
    public int Id { get; set; }

    public string? CourseName { get; set; }

    public int? Courseid { get; set; }

    public string? Location { get; set; }

    public string? Description { get; set; }
}
