using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgrammerEvaluationLoginActivityLog
{
    public int Id { get; set; }

    public int? LoginId { get; set; }

    public string? Name { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? TimeSpan { get; set; }

    public bool? ActiveUser { get; set; }

    public bool DeleteUser { get; set; }
}
